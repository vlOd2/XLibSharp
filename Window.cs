﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace X11
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
        public IntPtr data;
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
        public IntPtr obdata;
        private struct funcs
        {
            IntPtr create_image;
            IntPtr destroy_image;
            IntPtr get_pixel;
            IntPtr put_pixel;
            IntPtr sub_image;
            IntPtr add_pixel;
        }

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XWindowAttributes
    {
        public int x, y;
        public uint width, height;
        public int border_width;
        public int depth;
        public IntPtr visual;
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
        public IntPtr screen;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XSetWindowAttributes
    {
        public XPixmap background_pixmap;   /* background or None or ParentRelative */
        public ulong background_pixel;     /* background pixel */
        public XPixmap border_pixmap;       /* border of the window */
        public ulong border_pixel; /* border pixel value */
        public int bit_gravity;            /* one of bit gravity values */
        public int win_gravity;            /* one of the window gravity values */
        public int backing_store;          /* NotUseful, WhenMapped, Always */
        public ulong backing_planes;/* planes to be preseved if possible */
        public ulong backing_pixel;/* value to use in restoring planes */
        public bool save_under;            /* should bits under be saved? (popups) */
        public XEventMask event_mask;            /* set of events that should be saved */
        public XEventMask do_not_propagate_mask; /* set of events that should not propagate */
        public bool override_redirect;     /* boolean value for override-redirect */
        public XColormap colormap;          /* color map to be associated with window */
        public XCursor cursor;
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

    public partial class Xlib
    {
        /// <summary>
        /// The XGetWindowAttributes function returns the current attributes for the specified window to an XWindowAt‐
        /// tributes structure.It returns a nonzero status on success; otherwise, it returns a zero status.
        /// </summary>
        /// <param name="display"></param>
        /// <param name="window"></param>
        /// <param name="attributes"></param>
        [DllImport("libX11.so.6")]
        public static extern XStatus XGetWindowAttributes(IntPtr display, XWindow window, out XWindowAttributes attributes);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDestroyWindow(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XReparentWindow(IntPtr display, XWindow window, XWindow parent, int x, int y);

        [DllImport("libX11.so.6")]
        public static extern XStatus XAddToSaveSet(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveFromSaveSet(IntPtr dispay, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XChangeSaveSet(IntPtr display, XWindow window, XChangeMode change_mode);

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
        public static extern ref XImage XGetImage(IntPtr display, XWindow drawable, int x, int y,
            uint width, uint height, ulong plane_mask, XPixmapFormat format);


        [DllImport("libX11.so.6")]
        public static extern XStatus XSelectInput(IntPtr display, XWindow window, XEventMask event_mask);

        [DllImport("libX11.so.6")]
        private static extern int XQueryTree(IntPtr display, XWindow window, ref XWindow WinRootReturn,
            ref XWindow WinParentReturn, ref IntPtr ChildrenReturn, ref uint nChildren);
        public static int XQueryTree(IntPtr display, XWindow window, ref XWindow WinRootReturn,
            ref XWindow WinParentReturn, out List<XWindow> ChildrenReturn)
        {
            ChildrenReturn = new List<XWindow>();
            IntPtr pChildren = new IntPtr();
            uint nChildren = 0;

            var r = Xlib.XQueryTree(display, window, ref WinRootReturn, ref WinParentReturn,
                ref pChildren, ref nChildren);

            for (int i = 0; i < nChildren; i++)
            {
                var ptr = new IntPtr(pChildren.ToInt64() + i * sizeof(XWindow));
                ChildrenReturn.Add((XWindow)Marshal.ReadInt64(ptr));
            }

            return r;
        }

        [DllImport("libX11.so.6")]
        public static extern XWindow XCreateSimpleWindow(IntPtr display, XWindow parent, int x, int y,
            uint width, uint height, uint border_width, ulong border_colour, ulong background_colour);

        [DllImport("libX11.so.6")]
        public static extern XWindow XCreateWindow(IntPtr display, XWindow parent, int x, int y, uint width,
            uint height, uint border_width, int depth, uint @class, IntPtr visual, ulong valuemask,
              ref XSetWindowAttributes attributes);

        [DllImport("libX11.so.6")]
        public static extern int XMapWindow(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern int XUnmapWindow(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern int XConfigureWindow(IntPtr display, XWindow window, ulong value_mask, ref XWindowChanges changes);

        [DllImport("libX11.so.6")]
        public static extern int XSetWindowBackground(IntPtr display, XWindow window, ulong pixel);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetWindowBorder(IntPtr display, XWindow window, ulong border_pixel);

        [DllImport("libX11.so.6")]
        public static extern int XClearWindow(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern int XMoveWindow(IntPtr display, XWindow window, int x, int y);

        [DllImport("libX11.so.6")]
        public static extern XStatus XResizeWindow(IntPtr display, XWindow window, uint width, uint height);

        [DllImport("libX11.so.6")]
        public static extern XStatus XMoveResizeWindow(IntPtr display, XWindow window, int x, int y, uint width, uint height);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetWindowBorderWidth(IntPtr display, XWindow window, uint width);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetInputFocus(IntPtr display, XWindow focus, XRevertFocus revert_to, long time);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetInputFocus(IntPtr display, ref XWindow focus_return, ref XRevertFocus revert_to_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRaiseWindow(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XLowerWindow(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XCirculateSubwindows(IntPtr display, XWindow window, XDirection direction);

        [DllImport("libX11.so.6")]
        public static extern XStatus XCirculateSubwindowsUp(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XCirculateSubwindowsDown(IntPtr display, XWindow window);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRestackWindows(IntPtr display, IntPtr windows, int nwindows);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFetchName(IntPtr display, XWindow window, ref String name_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XStoreName(IntPtr display, XWindow window, string window_name);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDrawString(IntPtr display, XWindow drawable, IntPtr gc, int x, int y, string str, int length);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetSelectionOwner(IntPtr display, XAtom atom, XWindow window, long time);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetSelectionOwner(IntPtr display, XAtom atom, XWindow window, long time);

        [DllImport("libX11.so.6")]
        public static extern bool XQueryPointer(IntPtr display, XWindow window, ref XWindow window_return, ref XWindow child_return,
            ref int root_x, ref int root_y, ref int win_x, ref int win_y, ref uint mask);

        [DllImport("libX11.so.6")]
        public static extern int XGetGeometry(IntPtr display, XWindow drawable, ref XWindow root,
            ref int x, ref int y, ref uint width, ref uint height, ref uint border, ref uint depth);
    }

}
