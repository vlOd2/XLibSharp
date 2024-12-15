using System.Runtime.InteropServices;

namespace X11
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XVisualInfo
    {
        public nint visual;
        public ulong visualid;
        public int screen;
        public int depth;
        public int c_class;
        public ulong red_mask;
        public ulong green_mask;
        public ulong blue_mask;
        public int colormap_size;
        public int bits_per_rgb;
    }

    public static class GLX
    {
        #region Tokens for glXChooseVisual and glXGetConfig
        public const uint GLX_USE_GL = 1;
        public const uint GLX_BUFFER_SIZE = 2;
        public const uint GLX_LEVEL = 3;
        public const uint GLX_RGBA = 4;
        public const uint GLX_DOUBLEBUFFER = 5;
        public const uint GLX_STEREO = 6;
        public const uint GLX_AUX_BUFFERS = 7;
        public const uint GLX_RED_SIZE = 8;
        public const uint GLX_GREEN_SIZE = 9;
        public const uint GLX_BLUE_SIZE = 10;
        public const uint GLX_ALPHA_SIZE = 11;
        public const uint GLX_DEPTH_SIZE = 12;
        public const uint GLX_STENCIL_SIZE = 13;
        public const uint GLX_ACCUM_RED_SIZE = 14;
        public const uint GLX_ACCUM_GREEN_SIZE = 15;
        public const uint GLX_ACCUM_BLUE_SIZE = 16;
        public const uint GLX_ACCUM_ALPHA_SIZE = 17;
        #endregion

        #region Error codes returned by glXGetConfig
        public const uint GLX_BAD_SCREEN = 1;
        public const uint GLX_BAD_ATTRIBUTE = 2;
        public const uint GLX_NO_EXTENSION = 3;
        public const uint GLX_BAD_VISUAL = 4;
        public const uint GLX_BAD_CONTEXT = 5;
        public const uint GLX_BAD_VALUE = 6;
        public const uint GLX_BAD_ENUM = 7;
        #endregion

        #region GLX 1.0 and later
        [DllImport("libGLX.so.0")]
        public static extern nint glXChooseVisual(XDisplay dpy, int screen, int[] attribList);

        [DllImport("libGLX.so.0")]
        public static extern GLXContext glXCreateContext(XDisplay dpy, nint vis, nint shareList,
            [MarshalAs(UnmanagedType.Bool)] bool direct);

        [DllImport("libGLX.so.0")]
        public static extern void glXDestroyContext(XDisplay dpy, GLXContext ctx);

        [DllImport("libGLX.so.0")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool glXMakeCurrent(XDisplay dpy, GLXDrawable drawable, GLXContext ctx);

        [DllImport("libGLX.so.0")]
        public static extern void glXCopyContext(XDisplay dpy, GLXContext src, GLXContext dst, ulong mask);

        [DllImport("libGLX.so.0")]
        public static extern void glXSwapBuffers(XDisplay dpy, GLXDrawable drawable);

        [DllImport("libGLX.so.0")]
        public static extern GLXPixmap glXCreateGLXPixmap(XDisplay dpy, nint visual, XPixmap pixmap);

        [DllImport("libGLX.so.0")]
        public static extern void glXDestroyGLXPixmap(XDisplay dpy, GLXPixmap pixmap);

        [DllImport("libGLX.so.0")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool glXQueryExtension(XDisplay dpy, ref int errorb, ref int @event);

        [DllImport("libGLX.so.0")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool glXQueryVersion(XDisplay dpy, ref int maj, ref int min);

        [DllImport("libGLX.so.0")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool glXIsDirect(XDisplay dpy, GLXContext ctx);

        [DllImport("libGLX.so.0")]
        public static extern int glXGetConfig(XDisplay dpy, nint visual, int attrib, ref int value);

        [DllImport("libGLX.so.0")]
        public static extern GLXContext glXGetCurrentContext();

        [DllImport("libGLX.so.0")]
        public static extern GLXDrawable glXGetCurrentDrawable();

        [DllImport("libGLX.so.0")]
        public static extern void glXWaitGL();

        [DllImport("libGLX.so.0")]
        public static extern void glXWaitX();

        [DllImport("libGLX.so.0")]
        public static extern void glXUseXFont(XFont font, int first, int count, int list);
        #endregion

        #region GLX 1.1 and later
        public const uint GLX_VENDOR = 1;
        public const uint GLX_VERSION = 2;
        public const uint GLX_EXTENSIONS = 3;

        [DllImport("libGLX.so.0")]
        public static extern string glXQueryExtensionsString(XDisplay dpy, int screen);

        [DllImport("libGLX.so.0")]
        public static extern string glXQueryServerString(XDisplay dpy, int screen, int name);

        [DllImport("libGLX.so.0")]
        public static extern string glXGetClientString(XDisplay dpy, int name);
        #endregion

        #region GLX 1.2 and later
        [DllImport("libGLX.so.0")]
        public static extern XDisplay glXGetCurrentDisplay();
        #endregion

        #region GLX 1.4 and later
        [DllImport("libGLX.so.0")]
        public static extern nint glXGetProcAddress(string procname);
        #endregion
    }
}
