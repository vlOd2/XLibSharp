using System;
using System.Runtime.InteropServices;

namespace XLibSharp
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

    public partial class XLib
    {
        [DllImport("libX11.so.6")]
        public static extern XStatus XSetScreenSaver(nint display, int timeout, int interval, XScreenSaverBlanking prefer_blanking, 
            XScreenSaverExposures allow_exposures);

        [DllImport("libX11.so.6")]
        public static extern XStatus XForceScreenSaver(nint display, XScreenSaverMode mode);

        [DllImport("libX11.so.6")]
        public static extern XStatus XActivateScreenSaver(nint display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XResetScreenSaver(nint display);

        [DllImport("libX11.so.6")]
        public static extern XStatus XGetScreenSaver(nint display, ref int timeout_return, ref int interval_return, 
            ref XScreenSaverBlanking prefer_blanking_return, ref XScreenSaverExposures allow_exposures_return);

        [DllImport("libXss.so.1")]
        public static extern XStatus XScreenSaverQueryInfo(nint display, XWindow drawable, ref XScreenSaverInfo saver_info);
    }
}
