
namespace CommandPattern.Implementation.Command;

public class InputControlRangeCommand : Command
{
    private readonly Model.Abstract.InputControl<Range> _control;
    private Range _value;

    public InputControlRangeCommand(Model.Abstract.InputControl<Range> control)
    {
        _control = control;
    }
    
    public void SetInputValue(Range value)
    {
        _value = value;
    }
    
    public override void Execute()
    {
        _control.OnInput(_value);
    }
}