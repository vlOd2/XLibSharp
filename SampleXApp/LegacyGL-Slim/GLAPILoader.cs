// Copyright (c) vlOd
// Licensed under the GNU Affero General Public License, version 3.0

using System.Reflection;

internal class GLAPILoader
{
    private IGLLookup lookup;

    public GLAPILoader(IGLLookup lookup)
    {
        this.lookup = lookup;
    }

    public void Load()
    {
        Type type = typeof(GL);

        foreach (FieldInfo field in type.GetFields(BindingFlags.Static | BindingFlags.NonPublic))
        {
            Type fieldType = field.FieldType;
            object[] attributes = field.GetCustomAttributes(typeof(GLAPIAttribute), false);

            if (!typeof(Delegate).IsAssignableFrom(fieldType) || attributes.Length == 0)
            {
                Console.WriteLine($"Skipping {field.Name}");
                continue;
            }

            string entryPoint = ((GLAPIAttribute)attributes[0]).EntryPoint;
            Delegate @delegate = lookup.Lookup(fieldType, entryPoint, false);
            field.SetValue(null, @delegate);
        }
    }

    public void Unload()
    {
        Type type = typeof(GL);

        foreach (FieldInfo field in type.GetFields(BindingFlags.Static | BindingFlags.NonPublic))
        {
            Type fieldType = field.FieldType;
            object[] attributes = field.GetCustomAttributes(typeof(GLAPIAttribute), false);

            if (!typeof(Delegate).IsAssignableFrom(fieldType) || attributes.Length == 0)
            {
                Console.WriteLine($"Skipping {field.Name}");
                continue;
            }

            field.SetValue(null, null);
        }
    }
}