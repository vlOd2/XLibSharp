using System;
using System.Runtime.InteropServices;

namespace XLibSharp
{
    public partial class Xlib
    {

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFontPath(nint display, nint directories, int ndirs);

        [DllImport("libX11.so.6")]
        public static extern nint XGetFontPath(nint display, ref int npaths_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontPath(nint list);

        [DllImport("libX11.so.6")]
        public static extern nint XListFonts(nint display, string pattern, int maxnames, ref int actual_count_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontNames(nint list);

        [DllImport("libX11.so.6")]
        public static extern nint XListFontsWithInfo(nint display, string pattern, int maxnames, 
            ref int count_return, nint info_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontInfo(nint names, nint free_info, int actual_count);
    }
}
