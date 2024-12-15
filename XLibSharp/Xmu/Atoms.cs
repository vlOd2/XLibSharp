using System.Runtime.InteropServices;

namespace XLibSharp
{
    public partial class Xmu
    {
        [DllImport("libXmu.so.6")]
        public static extern XAtom XmuInternAtom(nint display, nint atomPtr);

        [DllImport("libXmu.so.6")]
        public static extern nint XmuMakeAtom(String name);
    }
}
