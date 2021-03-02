
using System;

public static partial class Extensions
{
    public static T[] @foreach <T> (this T[] array, Action <T> call)
    {
        for (int n = 0; n < array.Length; call (array[n++]) );
        return array;
    }

    public static T @apply <T> (this T obj, Action<T> call)
    {
        call (obj);
        return obj;
    }
}