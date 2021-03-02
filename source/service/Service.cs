
using System;
using System.Collections.Generic;

public sealed class Service
{
    private readonly Dictionary <string, dynamic> items = new ();

    public Service add (string name, dynamic item)
    {
        items.Add (name, item);
        return this;
    }

    public dynamic this [string name]
    {
        get => items [name];
    }
}