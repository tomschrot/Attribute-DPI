
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property)]
public sealed class InjectAttribute : Attribute {
    //---------------------------------------------------------------------
    // static

    private static Service service;

    public  static Service register (Service s) => service = s;

    //---------------------------------------------------------------------
    // properties

    public string  name  { get; private set; }
    public dynamic value { get => service [name]; }

    //---------------------------------------------------------------------
    // ctor

    public InjectAttribute (string name) => this.name = name;

    //---------------------------------------------------------------------
    // methods

    public void inject (object target, PropertyInfo property)
                =>
                    property
                    .SetValue (target, this.value);
    //---------------------------------------------------------------------
}