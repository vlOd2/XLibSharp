using System;
using System.Runtime.InteropServices;

namespace X11
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XHostAddress
    {
        public int family;
        public int length;
        public IntPtr address;
    }

    public partial class Xlib
    {
        [DllImport("libX11.so.6")]
        public static extern XStatus XAddHost(IntPtr display, ref XHostAddress host);

        [DllImport("libX11.so.6")]
        public static extern XStatus XAddHosts(IntPtr display, ref XHostAddress hosts, int num_hosts);

        [DllImport("libX11.so.6")]
        public static extern ref XHostAddress XListHosts(IntPtr display, ref int nhosts_return, ref bool state_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveHost(IntPtr display, ref XHostAddress host);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveHosts(IntPtr display, ref XHostAddress hosts, int num_hosts);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetAccessControl(IntPtr display, int mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XEnableAccessControl(IntPtr display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDisableAccessControl(IntPtr display);
    }
}
