
public sealed class Test : Injectable
{
    [Inject ("user")]
    private User user  { get; set; }

    [Inject ("logg")]
    public Logger logg { get; private set; }
}