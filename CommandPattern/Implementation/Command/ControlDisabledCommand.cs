

using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlDisableCommand : Command
{
    private readonly Model.Abstract.Control _control;
    
    public ControlDisableCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public override void Execute()
    {
        _control.Disable();
    }
}