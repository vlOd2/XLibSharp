// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

[AttributeUsage(AttributeTargets.Field)]
internal class GLAPIAttribute : Attribute
{
    public string EntryPoint;

    public GLAPIAttribute(string entryPoint)
    {
        EntryPoint = entryPoint;
    }
}