using System.Runtime.InteropServices;

namespace XLibSharp
{
    public partial class XLib
    {
        [DllImport("libX11.so.6")]
        public static extern XStatus XSetFontPath(XDisplay display, nint directories, int ndirs);

        [DllImport("libX11.so.6")]
        public static extern nint XGetFontPath(XDisplay display, ref int npaths_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontPath(nint list);

        [DllImport("libX11.so.6")]
        public static extern nint XListFonts(XDisplay display, string pattern, int maxnames, ref int actual_count_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontNames(nint list);

        [DllImport("libX11.so.6")]
        public static extern nint XListFontsWithInfo(XDisplay display, string pattern, int maxnames,
            ref int count_return, nint info_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XFreeFontInfo(nint names, nint free_info, int actual_count);
    }
}
