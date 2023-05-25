using CommandPattern.Model.Abstract;

namespace CommandPattern.Model.Implementation;

public class Button : Control
{
    public Button(int id, string label) : base(id, label)
    {
    }
    
    public override void OnClick()
    {
        Console.WriteLine($"click {typeof(Button)}");
    }
}