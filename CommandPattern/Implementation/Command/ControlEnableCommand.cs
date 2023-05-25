

using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlEnableCommand : ICommand
{
    private readonly Model.Abstract.Control _control;
    
    public ControlEnableCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public void Execute()
    {
        _control.Enable();
    }
}