using System;
using XLibSharp;
using static XLibSharp.XLib;
using static XLibSharp.GLX;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

public class Program
{
    private static readonly int[] GLX_ATTRIBS = { GLX_RGBA, GLX_DEPTH_SIZE, 24, GLX_DOUBLEBUFFER, 0 };
    private nint display;
    private ulong rootWindow;
    private nint visualInfoPtr;
    private XVisualInfo visualInfo;
    private ulong colorMap;
    private ulong window;
    private uint windowWidth = 800;
    private uint windowHeight = 600;
    private nint context;

    private int ErrorHandler(nint display, ref XErrorEvent e)
    {
        nint str = Marshal.AllocHGlobal(1024);
        XGetErrorText(display, e.error_code, str, 1024);
        Console.Error.WriteLine($"X11 Error: {Marshal.PtrToStringAnsi(str)} ({e.error_code})");
        Marshal.FreeHGlobal(str);
        return 0;
    }

    private void Init()
    {
        Console.WriteLine("Initializing");
        display = XOpenDisplay(null);
        if (display == nint.Zero)
        {
            Console.Error.WriteLine("Failed to open display");
            return;
        }
        rootWindow = XDefaultRootWindow(display);
        XSetErrorHandler(ErrorHandler);
    }

    private void Destroy(int code)
    {
        Console.WriteLine("Destroying");
        if (context != nint.Zero)
        {
            glXMakeCurrent(display, 0, nint.Zero);
            glXDestroyContext(display, context);
        }
        XFreeColormap(display, colorMap);
        XDestroyWindow(display, window);
        XCloseDisplay(display);
        Environment.Exit(code);
    }

    private void SetupVisual()
    {
        visualInfoPtr = glXChooseVisual(display, 0, GLX_ATTRIBS);
        if (visualInfoPtr == nint.Zero)
        {
            Console.Error.WriteLine("Could not get an appropriate visual");
            Destroy(1);
            return;
        }
        visualInfo = Marshal.PtrToStructure<XVisualInfo>(visualInfoPtr);
        colorMap = XCreateColormap(display, rootWindow, visualInfo.visual, XColormapAlloc.AllocNone);
    }

    private void CreateWindow()
    {
        Console.WriteLine("Creating window\n");

        XAttributeMask attribMask = XAttributeMask.CW_BACK_PIXEL |
                                    XAttributeMask.CW_EVENT_MASK |
                                    XAttributeMask.CW_COLORMAP;
        XSetWindowAttributes attribs = new()
        {
            background_pixel = 0xFF_00_00_00,
            event_mask = XEventMask.ExposureMask | XEventMask.StructureNotifyMask,
            colormap = colorMap
        };

        window = XCreateWindow(display, rootWindow,
            0, 0, windowWidth, windowHeight,
            0, visualInfo.depth, 1, visualInfo.visual,
            attribMask, ref attribs);
        XMapWindow(display, window);
        XStoreName(display, window, "Game");

        XFlush(display);
    }

    private void CreateGLContext()
    {
        context = glXCreateContext(display, visualInfoPtr, 0, true);
        glXMakeCurrent(display, window, context);
    }

    private void PollEvents(ulong wmDeleteWindow)
    {
        nint eventPtr = Marshal.AllocHGlobal(24 * sizeof(long));
        if (!XCheckTypedWindowEvent(display, window, XEvent.ClientMessage, eventPtr) &&
            !XCheckMaskEvent(display, (XEventMask)long.MaxValue, eventPtr))
            return;

        // XEvent type = (XEvent)Marshal.PtrToStructure<XAnyEvent>(eventPtr).type;
        XEvent type = (XEvent)Marshal.ReadInt32(eventPtr);
        switch (type)
        {
            case XEvent.ClientMessage:
                {
                    XClientMessageEvent e = Marshal.PtrToStructure<XClientMessageEvent>(eventPtr);
                    if ((ulong)e.data == wmDeleteWindow)
                        Destroy(0);
                    break;
                }
        }
    }

    public void Run()
    {
        Init();
        SetupVisual();
        CreateWindow();
        CreateGLContext();

        XAtom wmDeleteWindow = XInternAtom(display, "WM_DELETE_WINDOW", false);
        if (XSetWMProtocols(display, window, ref wmDeleteWindow, 1) == XStatus.Failure)
            Console.Error.WriteLine("WM_DELETE_WINDOW failed");

        while (true)
        {
            glXSwapBuffers(display, window);
            PollEvents((ulong)wmDeleteWindow);
        }
    }

    public static void Main(string[] args)
    {
        new Program().Run();
    }
}