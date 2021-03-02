
using System.Reflection;

public abstract class Injectable
{
    private const BindingFlags restriction =
                      BindingFlags.Instance
                    | BindingFlags.Public
                    | BindingFlags.NonPublic
                    | BindingFlags.SetProperty
                    ;

    protected   Injectable ()
                =>
                    this
                    .GetType       ( )
                    .GetProperties ( restriction )
                    .@foreach      ( property =>

                        property
                        .GetCustomAttribute <InjectAttribute> ()
                        ?.inject (this, property)
                    );
}