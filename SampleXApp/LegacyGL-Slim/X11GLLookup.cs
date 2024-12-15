// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Runtime.InteropServices;
using XLibSharp;

internal class X11GLLookup : IGLLookup
{
    public Delegate Lookup(Type delegateType, string entryPoint, bool optional = false)
    {
        string name = entryPoint;

        IntPtr funcPtr = GLX.glXGetProcAddress(name);
        if (funcPtr == IntPtr.Zero)
        {
            if (optional)
            {
                Console.Error.WriteLine($"Optional method {name} couldn't be found");
                return null;
            }
            else
                throw new Exception($"{name} couldn't be found");
        }

        return Marshal.GetDelegateForFunctionPointer(funcPtr, delegateType);
    }

    public T Lookup<T>(bool optional = false) where T : Delegate
        => (T)Lookup(typeof(T), typeof(T).Name, optional);
}