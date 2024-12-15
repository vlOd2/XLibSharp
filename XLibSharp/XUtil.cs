using System.Runtime.InteropServices;

namespace XLibSharp
{
    public class XUtil
    {
        /// <summary>
        /// Free a previously allocated XImage.
        /// </summary>
        /// <param name="img">The XImage structure to free.</param>
        /// <returns>non-zero on success, zero on failure.</returns>
        [DllImport("libX11.so.6")]
        public static extern int XDestroyImage(ref XImage img);
    }
}
