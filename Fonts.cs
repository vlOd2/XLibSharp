using System;
using System.Runtime.InteropServices;

namespace X11
{
    public partial class Xlib
    {

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFontPath(IntPtr display, IntPtr directories, int ndirs);

        [DllImport("libX11.so.6")]
        public static extern IntPtr XGetFontPath(IntPtr display, ref int npaths_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontPath(IntPtr list);

        [DllImport("libX11.so.6")]
        public static extern IntPtr XListFonts(IntPtr display, string pattern, int maxnames, ref int actual_count_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontNames(IntPtr list);

        [DllImport("libX11.so.6")]
        public static extern IntPtr XListFontsWithInfo(IntPtr display, string pattern, int maxnames, 
            ref int count_return, IntPtr info_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontInfo(IntPtr names, IntPtr free_info, int actual_count);
    }
}
