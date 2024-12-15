using System;
using System.Runtime.InteropServices;

namespace X11
{        
    public enum XGCComponents: ulong
    {
         GCFunction = (1L<<0),
         GCPlaneMask = (1L<<1),
         GCForeground = (1L<<2),
         GCBackground = (1L<<3),
         GCLineWidth = (1L<<4),
         GCLineStyle = (1L<<5),
         GCCapStyle = (1L<<6),
         GCJoinStyle = (1L<<7),
         GCFillStyle = (1L<<8),
         GCFillRule = (1L<<9),
         GCTile = (1L<<10),
         GCStipple = (1L<<11),
         GCTileStipXOrigin = (1L<<12),
         GCTileStipYOrigin = (1L<<13),
         GCFont = (1L<<14),
         GCSubwindowMode = (1L<<15),
         GCGraphicsExposures = (1L<<16),
         GCClipXOrigin = (1L<<17),
         GCClipYOrigin = (1L<<18),
         GCClipMask = (1L<<19),
         GCDashOffset = (1L<<20),
         GCDashList = (1L<<21),
         GCArcMode = (1L<<22),
    }

    public enum XLineStyle: int
    {
        LineSolid = 0,
        LineOnOffDash = 1,
        LineDoubleDash = 2,
    }

    public enum XCapStyle: int
    {
        CapNotLast = 0,
        CapButt = 1,
        CapRound = 2,
        CapProjecting = 3,
    }

    public enum XJoinStyle: int
    {
        JoinMiter = 0,
        JoinRound = 1,
        JoinBevel = 2,
    }

    public enum XFillStyle: int
    {
        FillSolid = 0,
        FillTiled = 1,
        FillStippled = 2,
        FillOpaqueStippled = 3,
    }

    public enum XFillRule: int
    {
        EvenOddRule = 0,
        WindingRule = 1,
    }

    public enum XSubwindowMode: int
    {
        ClipByChildren = 0,
        IncludeInferiors = 1,
    }

    public enum XArcMode: int
    {
        /// <summary>
        /// join endpoints of arc
        /// </summary>
        ArcChord = 0, 
        /// <summary>
        /// join endpoints to center of arc
        /// </summary>
        ArcPieSlice = 1,
    }

    public enum XBestSizeClass: int
    {
        /// <summary>
        /// largest size that can be displayed
        /// </summary>
        CursorShape = 0,
        /// <summary>
        /// size tiled fastest
        /// </summary>
        TileShape = 1,
        /// <summary>
        /// Size stippled fastest
        /// </summary>
        StippleShape = 2,
    }

    public enum XClipOrdering: int
    {
        Unsorted = 0,
        YSorted = 1,
        YXSorted = 2,
        YXBanded = 3,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XRectangle {
        short x, y;
        ushort width, height;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct XGCValues
    {
        int function;       /* logical operation */
        ulong plane_mask;/* plane mask */
        ulong foreground;/* foreground pixel */
        ulong background;/* background pixel */
        int line_width;     /* line width */
        XLineStyle line_style;     /* LineSolid, LineOnOffDash, LineDoubleDash */
        XCapStyle cap_style;      /* CapNotLast, CapButt, CapRound, CapProjecting */
        XJoinStyle join_style;     /* JoinMiter, JoinRound, JoinBevel */
        XFillStyle fill_style;     /* FillSolid, FillTiled, FillStippled, FillOpaeueStippled */
        XFillRule fill_rule;      /* EvenOddRule, WindingRule */
        XArcMode arc_mode;       /* ArcChord, ArcPieSlice */
        XPixmap tile;        /* tile pixmap for tiling operations */
        XPixmap stipple;     /* stipple 1 plane pixmap for stipping */
        int ts_x_origin;    /* offset for tile or stipple operations */
        int ts_y_origin;
        XFont font;          /* default text font for text operations */
        XSubwindowMode subwindow_mode;     /* ClipByChildren, IncludeInferiors */
        bool graphics_exposures;/* boolean, should exposures be generated */
        int clip_x_origin;  /* origin for clipping */
        int clip_y_origin;
        XPixmap clip_mask;   /* bitmap clipping; other calls for rects */
        int dash_offset;    /* patterned/dashed line information */
        byte dashes;
    }

    public partial class Xlib
    {
        /// <summary>
        /// vThe XCreateGC function creates a graphics context and returns a GC.  The GC can be used with any destination
        /// drawable having the same root and depth as the specified drawable.
        /// </summary>
        /// <param name="display"></param>
        /// <param name="drawable"></param>
        /// <param name="valuemask"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        [DllImport("libX11.so.6")]
        public static extern IntPtr XCreateGC(IntPtr display, XWindow drawable, XGCComponents valuemask, ref XGCValues values);

        /// <summary>
        /// The XCopyGC function copies the specified components from the source GC to the destination GC.  
        /// The source and destination GCs must have the same root and depth.
        /// </summary>
        /// <param name="display"></param>
        /// <param name="src"></param>
        /// <param name="valuemask"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        [DllImport("libX11.so.6")]
        public static extern XStatus XCopyGC(IntPtr display, IntPtr src, XGCComponents valuemask, IntPtr dest);

        [DllImport("libX11.so.6")]
        public static extern XStatus XChangeGC(IntPtr display, IntPtr gc, ulong valuemask, ref XGCValues values);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetGCValues(IntPtr display, IntPtr gc, ulong valuemask,
            ref XGCValues values_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeGC(IntPtr display,  IntPtr gc);

        [DllImport("libX11.so.6")]
        public static extern XID XGContextFromGC(IntPtr gc);

        /// <summary>
        /// Force sending of GC changes immediately.
        /// </summary>
        /// <param name="display"></param>
        /// <param name="gc"></param>
        [DllImport("libX11.so.6")]
        public static extern void _XFlushGCCache(IntPtr display, IntPtr gc);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetState(IntPtr display, IntPtr gc, ulong foreground, ulong background, int function,
              ulong plane_mask);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFunction(IntPtr display, IntPtr gc, int function);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetPlaneMask(IntPtr display, IntPtr gc, ulong plane_mask);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetForeground(IntPtr display, IntPtr gc, ulong foreground);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetBackground(IntPtr display, IntPtr gc, ulong background);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetLineAttributes(IntPtr display, IntPtr gc, uint line_width, 
            XLineStyle line_style, XCapStyle cap_style, XJoinStyle join_style);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetDashes(IntPtr display, IntPtr gc, int dash_offset, byte[] dash_list, int n);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFillStyle(IntPtr display, IntPtr gc, XFillStyle fill_style);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFillRule(IntPtr display, IntPtr gc, XFillRule fill_rule);

        [DllImport("libX11.so.6")]
        public static extern XStatus XQueryBestSize(IntPtr display, XBestSizeClass best_size_class, XWindow which_screen, 
            uint width, uint height, ref uint width_return, ref uint height_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XQueryBestTile(IntPtr display, XWindow which_screen, uint width, uint height,
               ref uint width_return, ref uint height_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XQueryBestStipple(IntPtr display, XWindow which_screen, uint width, uint height,
               ref uint width_return, ref uint height_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetTile(IntPtr display, IntPtr gc, XPixmap tile);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetStipple(IntPtr display, IntPtr gc, XPixmap stipple);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetTSOrigin(IntPtr display, IntPtr gc, int ts_x_origin, int ts_y_origin);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFont(IntPtr display, IntPtr gc, XFont font);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetClipOrigin(IntPtr display, IntPtr gc, int clip_x_origin, int clip_y_origin);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetClipMask(IntPtr display, IntPtr gc, XPixmap pixmap);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetClipRectangles(IntPtr display, IntPtr gc, int clip_x_origin, int clip_y_origin,
            XRectangle[] rectangles, int n, XClipOrdering ordering);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetArcMode(IntPtr display, IntPtr gc, XArcMode arc_mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetSubwindowMode(IntPtr display, IntPtr gc, XSubwindowMode subwindow_mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetGraphicsExposures(IntPtr display, IntPtr gc, bool graphics_exposures);
    }
}
