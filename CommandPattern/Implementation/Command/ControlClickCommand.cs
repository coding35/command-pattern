namespace CommandPattern.Implementation.Command;

public class ControlClickCommand : Command
{
    private readonly Model.Abstract.Control _control;
    
    public ControlClickCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public override void Execute()
    {
        _control.Click();
    }
}