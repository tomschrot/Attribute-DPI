
using System;

public sealed class Logger
{
    public Logger write (string message)
    {
        Console.Write (message);
        return this;
    }

    public Logger write (string format, params object[] args)
    {
        Console.Write (format, args);
        return this;
    }
}