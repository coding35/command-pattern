

using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlDisableCommand : ICommand
{
    private readonly Model.Abstract.Control _control;
    
    public ControlDisableCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public void Execute()
    {
        _control.Disable();
    }
}