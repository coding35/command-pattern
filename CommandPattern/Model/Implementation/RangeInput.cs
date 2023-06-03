using CommandPattern.Model.Abstract;

namespace CommandPattern.Model.Implementation;

public class RangeInput<T> : InputControl<T>
{
    
    public RangeInput(int id, string label) : base(id, label)
    {
    }
    
    public override void OnClick()
    {
        throw new NotImplementedException();
    }

    public override void OnInput(T value)
    {
        Value = value;
    }
}