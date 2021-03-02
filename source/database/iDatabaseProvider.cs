
public interface iDatabaseProvider
{
    bool success     { get; }
    bool isConnected { get; }

    iDatabaseProvider open  (string connection);
    iDatabaseProvider query (string query);
    iDatabaseProvider close ();
}