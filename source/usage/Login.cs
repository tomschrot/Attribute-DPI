
using System.Collections.Generic;

public sealed class Login : Injectable
{
    [Inject ("user")]
    private User user { get; set; }

    [Inject ("data")]
    private iDatabaseProvider db { get; set; }

    public Login execute (string name, string password)
    {
        if (db.query("perform login").success)
        {
            var row = new Dictionary <string, dynamic>
            {
                ["name" ] = "Donald Duck",
                ["email"] = "donald@duck-inc.com",
                ["role" ] = User.Role.VENDOR
            };

            user.set (row);
        }

        return this;
    }
}