using CommandPattern.Model.Abstract;

namespace CommandPattern.Model.Implementation;

public class Toggle : Control
{
    public Toggle(int id, string label) : base(id, label)
    {
    }
    
    public override void OnClick()
    {
        Console.WriteLine($"click {typeof(Toggle)}");
    }
}