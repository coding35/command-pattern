namespace CommandPattern.Model.Abstract;

public abstract class Page
{
    protected Page(List<Control>? controls)
    {
        Controls = controls;
    }

    public static List<Control>? Controls { get; set; }
}