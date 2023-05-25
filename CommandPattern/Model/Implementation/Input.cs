using CommandPattern.Model.Abstract;

namespace CommandPattern.Model.Implementation;

public class Input : Control
{
    public Input(int id, string label) : base(id, label)
    {
    }
    
    public override void OnClick()
    {
        Console.WriteLine($"click {typeof(Input)}");
    }
    
}