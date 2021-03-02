
using System.Collections.Generic;

public sealed class User
{
    public enum Role
    {
        NONE,
        VENDOR,
        OFFICIAL,
        ADMIN
    }

    public string name      { get; private set; }
    public string email     { get; private set; }
    public Role   role      { get; private set; }

    public bool isLoggedIn  { get; private set; } = false;

    public User set (Dictionary<string, dynamic> row)
    {
        name        = row ["name"];
        email       = row ["email"];
        role        = row ["role"];
        isLoggedIn  = true;

        return this;
    }

    public User timeout ()
    {
        name        = string.Empty;
        email       = string.Empty;
        role        = Role.NONE;
        isLoggedIn  = false;

        return this;
    }

    override
    public string ToString() => $"{name}, {email} = {role}";
}