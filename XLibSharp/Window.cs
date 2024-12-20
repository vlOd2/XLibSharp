using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace XLibSharp
{
    public enum XPixmapFormat : int
    {
        XYBitmap = 0,
        XYPixmap = 1,
        ZPixmap = 2
    };

    public enum XDirection : int
    {
        RaiseLowest = 0,
        LowerHighest = 1,
    }

    public enum XChangeMode : int
    {
        SetModeInsert = 0,
        SetModeDelete = 1,
    }

    public enum XRevertFocus : int
    {
        RevertToNone = 0,
        RevertToPointerRoot = 1,
        RevertToParent = 2,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XImage
    {
        public int width, height;
        public int xoffset;
        public int format;
        public nint data;
        public int byte_order;
        public int bitmap_unit;
        public int bitmap_bit_order;
        public int bitmap_pad;
        public int depth;
        public int bytes_per_line;
        public int bits_per_pixel;
        public ulong red_mask;
        public ulong green_mask;
        public ulong blue_mask;
        public nint obdata;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XWindowAttributes
    {
        public int x, y;
        public uint width, height;
        public int border_width;
        public int depth;
        public nint visual;
        public XWindow root;
        public int @class;
        public int bit_gravity;
        public int win_gravity;
        public int backing_store;
        public ulong backing_planes;
        public ulong backing_pixel;
        public bool save_under;
        public XColormap colormap;
        public bool map_installed;
        public int map_state;
        public long all_event_masks;
        public long your_event_masks;
        public long do_not_propagate_mask;
        public bool override_redirect;
        public nint screen;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XSetWindowAttributes
    {
        public XPixmap background_pixmap; /* background or None or ParentRelative */
        public ulong background_pixel; /* background pixel */
        public XPixmap border_pixmap; /* border of the window */
        public ulong border_pixel; /* border pixel value */
        public int bit_gravity; /* one of bit gravity values */
        public int win_gravity; /* one of the window gravity values */
        public int backing_store; /* NotUseful, WhenMapped, Always */
        public ulong backing_planes; /* planes to be preseved if possible */
        public ulong backing_pixel; /* value to use in restoring planes */
        public bool save_under; /* should bits under be saved? (popups) */
        public XEventMask event_mask; /* set of events that should be saved */
        public XEventMask do_not_propagate_mask; /* set of events that should not propagate */
        public bool override_redirect; /* boolean value for override-redirect */
        public XColormap colormap; /* color map to be associated with window */
        public XCursor cursor;
    }

    public enum XAttributeMask : ulong
    {
        CW_BACK_PIXMAP = 1,
        CW_BACK_PIXEL = 2,
        CW_BORDER_PIXMAP = 4,
        CW_BORDER_PIXEL = 8,
        CW_BIT_GRAVITY = 16,
        CW_WIN_GRAVITY = 32,
        CW_BACKING_STORE = 64,
        CW_BACKING_PLANES = 128,
        CW_BACKING_PIXEL = 256,
        CW_OVERRIDE_REDIRECT = 512,
        CW_SAVE_UNDER = 1024,
        CW_EVENT_MASK = 2048,
        CW_DONT_PROPAGATE = 4096,
        CW_COLORMAP = 8192,
        CW_CURSOR = 16384
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XWindowChanges
    {
        public int x, y;
        public int width, height;
        public int border_width;
        public XWindow sibling;
        public int stack_mode;
    }

    public enum XWindowChangesMask : ulong
    {
        CWX = 1 << 0,
        CWY = 1 << 1,
        CWWidth = 1 << 2,
        CWHeight = 1 << 3,
        CWBorderWidth = 1 << 4,
        CWSibling = 1 << 5,
        CWStackMode = 1 << 6
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XSizeHints
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct XSizeHintsAspectRatio
        {
            public int x;
            public int y;
        }

        public long flags;
        public int x, y;
        public int width, height;
        public int min_width, min_height;
        public int max_width, max_height;
        public int width_inc, height_inc;
        public XSizeHintsAspectRatio min_aspect;
        public XSizeHintsAspectRatio max_aspect;
        public int base_width, base_height;
        public int win_gravity;
    }

    public enum XSizeHintsFlags : long
    {
        USPosition = 1L << 0,
        USSize = 1L << 1,
        PPosition = 1L << 2,
        PSize = 1L << 3,
        PMinSize = 1L << 4,
        PMaxSize = 1L << 5,
        PResizeInc = 1L << 6,
        PAspect = 1L << 7,
        PBaseSize = 1L << 8,
        PWinGravity = 1L << 9,
        PAllHints = PPosition | PSize | PMinSize | PMaxSize | PResizeInc | PAspect
    }

    public partial class XLib
    {
        /// <summary>
        /// The XGetWindowAttributes function returns the current attributes for the specified window to an XWindowAt‐
        /// tributes structure.It returns a nonzero status on success; otherwise, it returns a zero status.
        /// </summary>
        /// <param name="display"></param>
        /// <param name="window"></param>
        /// <param name="attributes"></param>
        [DllImport("libX11.so.6")]
        public static extern XStatus XGetWindowAttributes(XDisplay display, XWindow window,
            out XWindowAttributes attributes);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDestroyWindow(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XReparentWindow(XDisplay display, XWindow window, XWindow parent, int x, int y);

        [DllImport("libX11.so.6")]
        public static extern XStatus XAddToSaveSet(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveFromSaveSet(nint dispay, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XChangeSaveSet(XDisplay display, XWindow window, XChangeMode change_mode);

        /// <summary>
        /// Returns a pointer which can be marshalled to an XImage object for field access in managed code.
        /// This should be freed after use with the XDestroyImage function (from Xutil).
        /// </summary>
        /// <param name="display">Pointer to an open X display</param>
        /// <param name="drawable">Window ID to capture</param>
        /// <param name="x">X-offset for capture region</param>
        /// <param name="y">Y-offset for capture region</param>
        /// <param name="width">Width of capture region</param>
        /// <param name="height">Height of capture region</param>
        /// <param name="plane_mask"></param>
        /// <param name="format">One of XYBitmap, XYPixmap, ZPixmap</param>
        /// <returns></returns>
        [DllImport("libX11.so.6")]
        public static extern ref XImage XGetImage(XDisplay display, XWindow drawable, int x, int y,
            uint width, uint height, ulong plane_mask, XPixmapFormat format);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSelectInput(XDisplay display, XWindow window, XEventMask event_mask);

        [DllImport("libX11.so.6")]
        private static extern int XQueryTree(XDisplay display, XWindow window, ref XWindow WinRootReturn,
            ref XWindow WinParentReturn, ref nint ChildrenReturn, ref uint nChildren);

        public static int XQueryTree(XDisplay display, XWindow window, ref XWindow WinRootReturn,
            ref XWindow WinParentReturn, out List<XWindow> ChildrenReturn)
        {
            ChildrenReturn = new List<XWindow>();
            nint pChildren = new nint();
            uint nChildren = 0;
            int result = XQueryTree(display, window, ref WinRootReturn, ref WinParentReturn, ref pChildren,
                ref nChildren);

            for (int i = 0; i < nChildren; i++)
            {
                nint ptr = new nint(pChildren.ToInt64() + i * sizeof(XWindow));
                ChildrenReturn.Add((XWindow)Marshal.ReadInt64(ptr));
            }

            return result;
        }

        [DllImport("libX11.so.6")]
        public static extern XWindow XCreateSimpleWindow(XDisplay display, XWindow parent, int x, int y,
            int width, int height, uint border_width, ulong border_colour, ulong background_colour);

        [DllImport("libX11.so.6")]
        public static extern XWindow XCreateWindow(XDisplay display, XWindow parent, int x, int y, int width,
            int height, uint border_width, int depth, uint @class, nint visual, XAttributeMask valuemask,
            ref XSetWindowAttributes attributes);

        [DllImport("libX11.so.6")]
        public static extern int XChangeWindowAttributes(XDisplay display, XWindow window, XAttributeMask valuemask,
            ref XSetWindowAttributes attributes);

        [DllImport("libX11.so.6")]
        public static extern int XMapWindow(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern int XUnmapWindow(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern int XConfigureWindow(XDisplay display, XWindow window, ulong value_mask,
            ref XWindowChanges changes);

        [DllImport("libX11.so.6")]
        public static extern int XSetWindowBackground(XDisplay display, XWindow window, ulong pixel);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetWindowBorder(XDisplay display, XWindow window, ulong border_pixel);

        [DllImport("libX11.so.6")]
        public static extern int XClearWindow(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern int XMoveWindow(XDisplay display, XWindow window, int x, int y);

        [DllImport("libX11.so.6")]
        public static extern XStatus XResizeWindow(XDisplay display, XWindow window, uint width, uint height);

        [DllImport("libX11.so.6")]
        public static extern XStatus XMoveResizeWindow(XDisplay display, XWindow window, int x, int y, uint width,
            uint height);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetWindowBorderWidth(XDisplay display, XWindow window, uint width);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetInputFocus(XDisplay display, XWindow focus, XRevertFocus revert_to, long time);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetInputFocus(XDisplay display, ref XWindow focus_return,
            ref XRevertFocus revert_to_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRaiseWindow(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XLowerWindow(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XCirculateSubwindows(XDisplay display, XWindow window, XDirection direction);

        [DllImport("libX11.so.6")]
        public static extern XStatus XCirculateSubwindowsUp(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XCirculateSubwindowsDown(XDisplay display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRestackWindows(XDisplay display, nint windows, int nwindows);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFetchName(XDisplay display, XWindow window, ref string name_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XStoreName(XDisplay display, XWindow window, string window_name);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDrawString(XDisplay display, XWindow drawable, nint gc, int x, int y, string str,
            int length);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetSelectionOwner(XDisplay display, XAtom atom, XWindow window, long time);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetSelectionOwner(XDisplay display, XAtom atom, XWindow window, long time);

        [DllImport("libX11.so.6")]
        public static extern bool XQueryPointer(XDisplay display, XWindow window, ref XWindow window_return,
            ref XWindow child_return,
            ref int root_x, ref int root_y, ref int win_x, ref int win_y, ref uint mask);

        [DllImport("libX11.so.6")]
        public static extern int XGetGeometry(XDisplay display, XWindow drawable, ref XWindow root,
            ref int x, ref int y, ref uint width, ref uint height, ref uint border, ref uint depth);

        [DllImport("libX11.so.6")]
        public static extern void XSetWMNormalHints(XDisplay display, XWindow w, ref XSizeHints hints);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetWMNormalHints(XDisplay display, XWindow w, ref XSizeHints hints_return,
            out long supplied_return);

        [DllImport("libX11.so.6")]
        public static extern void XSetWMSizeHints(XDisplay display, XWindow w, ref XSizeHints hints, XAtom property);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetWMSizeHints(XDisplay display, XWindow w, ref XSizeHints hints_return,
            out long supplied_return, XAtom property);

        [DllImport("libX11.so.6")]
        public static extern nint XAllocSizeHints();

        [DllImport("libX11.so.6")]
        public static extern XKeySym XLookupKeysym(ref XKeyEvent key_event, int index);
    }
}