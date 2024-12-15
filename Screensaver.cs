using System;
using System.Runtime.InteropServices;

namespace X11
{
    public enum XScreenSaverExposures: int
    {
        DontAllowExposures = 0,
        AllowExposures = 1,
        DefaultExposures = 2,
    }

    public enum XScreenSaverMode: int
    {
        ScreenSaverReset = 0,
        ScreenSaverActive = 1,
    }

    public enum XScreenSaverBlanking: int
    {
        DontPreferBlanking = 0,
        PreferBlanking = 1,
        DefaultBlanking = 2,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct XScreenSaverInfo
    {
        public XWindow window;
        public int state;
        public int kind;
        public ulong til_or_since;
        public ulong idle;
        public ulong eventMask;
    }

    public partial class Xlib
    {
        [DllImport("libX11.so.6")]
        public static extern XStatus XSetScreenSaver(IntPtr display, int timeout, int interval, XScreenSaverBlanking prefer_blanking, 
            XScreenSaverExposures allow_exposures);

        [DllImport("libX11.so.6")]
        public static extern XStatus XForceScreenSaver(IntPtr display, XScreenSaverMode mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XActivateScreenSaver(IntPtr display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XResetScreenSaver(IntPtr display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetScreenSaver(IntPtr display, ref int timeout_return, ref int interval_return, 
            ref XScreenSaverBlanking prefer_blanking_return, ref XScreenSaverExposures allow_exposures_return);

        [DllImport("libXss.so.1")]
        public static extern XStatus XScreenSaverQueryInfo(IntPtr display, XWindow drawable, ref XScreenSaverInfo saver_info);
    }
}
