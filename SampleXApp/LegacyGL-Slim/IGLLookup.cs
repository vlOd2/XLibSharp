// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

internal interface IGLLookup
{
    Delegate Lookup(Type delegateType, string entryPoint, bool optional = false);

    T Lookup<T>(bool optional = false) where T : Delegate;
}