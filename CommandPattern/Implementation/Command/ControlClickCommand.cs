using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlClickCommand : ICommand
{
    private readonly Model.Abstract.Control _control;
    
    public ControlClickCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public void Execute()
    {
        _control.Click();
    }
}