
using System;

public sealed class MyDatabase : iDatabaseProvider
{
    private string connection;

    public bool success     { get; private set; }
    public bool isConnected { get; private set; }

    public MyDatabase() {}

    public MyDatabase(string connection) => open (connection);

    public iDatabaseProvider open (string connection)
    {
        close();
        this.connection = connection;
        isConnected     = true;
        success         = true;
        return this;
    }

    public iDatabaseProvider close ()
    {
        isConnected = false;
        success     = true;
        return this;
    }

    public iDatabaseProvider query (string query)
    {
        Console.WriteLine ("Database query: {0}", query);
        success = true;
        return this;
    }
}