
using System;

const string
         USER = "user"
        ,LOGG = "logg"
        ,DATA = "data"
        ;

Console.WriteLine
(
    "Attribute DPI\n"
    +"(c) tomschrot@gmail.com\n"
    +"\n"
);

Service appService = InjectAttribute.register
(
    new Service ()
    .add (USER, new User       () )
    .add (LOGG, new Logger     () )
    .add (DATA, new MyDatabase ("server=localhost; user=dbclient;") )
);

appService [LOGG]
.write ( "Connected to database: {0}\n", appService [DATA].isConnected )
.write ( "User is: {0}\n"              , appService [USER].ToString()  )
;

new Login ()
.execute
(
    name    : "donaldduck",
    password: "IloveDaisy"
);

appService [LOGG]
.write ( "Loggin {0}\n"  , appService [USER].isLoggedIn )
.write ( "User is: {0}\n", appService [USER].ToString() )
;

new Booking
{
    customer = "Daisy Duck",
    arrive   = new DateTime (2025, 2, 14),
    depart   = new DateTime (2025, 2, 16),
}
.save ()
;

appService [USER].timeout ();

new Booking
{
    customer = "Mickey Mouse",
    arrive   = new DateTime (2025, 5, 1),
    depart   = new DateTime (2025, 5, 13),
}
.save ()
;
