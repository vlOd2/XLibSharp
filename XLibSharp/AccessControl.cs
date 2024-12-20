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

    public partial class XLib
    {
        [DllImport("libX11.so.6")]
        public static extern XStatus XAddHost(XDisplay display, ref XHostAddress host);

        [DllImport("libX11.so.6")]
        public static extern XStatus XAddHosts(XDisplay display, ref XHostAddress hosts, int num_hosts);

        [DllImport("libX11.so.6")]
        public static extern ref XHostAddress XListHosts(XDisplay display, ref int nhosts_return, ref bool state_return);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveHost(XDisplay display, ref XHostAddress host);

        [DllImport("libX11.so.6")]
        public static extern XStatus XRemoveHosts(XDisplay display, ref XHostAddress hosts, int num_hosts);

        [DllImport("libX11.so.6")]
        public static extern XStatus XSetAccessControl(XDisplay display, int mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XEnableAccessControl(XDisplay display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XDisableAccessControl(XDisplay display);
    }
}
