
using System;
public sealed class Booking : Injectable
{
    [Inject ("user")]
    private User user { get; set; }

    [Inject ("data")]
    private iDatabaseProvider db { get; set; }

    [Inject ("logg")]
    private Logger logg { get; set; }

    public string   customer { get; set; }
    public DateTime arrive   { get; set; }
    public DateTime depart   { get; set; }

    public Booking () => logg.write ("New booking created.\n");

    public Booking save ()
    {
        if (user.role == User.Role.VENDOR)
        {
            if (db.query("save booking to db...").success)
            {
                logg.write ("Booking for {0} saved.\n", customer);
            }
            else
                logg.write ("Error saving booking for {0}", customer);
        }
        else
            logg.write ("Insufficient user rights!\n");

        return this;
    }
}