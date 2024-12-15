using System;
using System.Runtime.InteropServices;

namespace XLibSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XHostAddress
    {
        public int family;
        public int length;
        public nint address;
    }

    public partial class Xlib
    {
        [DllImport("libX11.so.6")]
        public static extern XStatus XAddHost(nint display, ref XHostAddress host);

        [DllImport("libX11.so.6")]
        public static extern XStatus XAddHosts(nint display, ref XHostAddress hosts, int num_hosts);

        [DllImport("libX11.so.6")]
        public static extern ref XHostAddress XListHosts(nint display, ref int nhosts_return, ref bool state_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveHost(nint display, ref XHostAddress host);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveHosts(nint display, ref XHostAddress hosts, int num_hosts);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetAccessControl(nint display, int mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XEnableAccessControl(nint display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDisableAccessControl(nint display);
    }
}
