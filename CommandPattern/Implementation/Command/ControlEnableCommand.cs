

using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlEnableCommand : Command
{
    private readonly Model.Abstract.Control _control;
    
    public ControlEnableCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public override void Execute()
    {
        _control.Enable();
    }
}