using CommandPattern.Model.Abstract;

namespace CommandPattern.Model.Implementation;

public class HomePage : Page
{
    public HomePage(List<Control>? controls) : base(controls)
    {
    }
}