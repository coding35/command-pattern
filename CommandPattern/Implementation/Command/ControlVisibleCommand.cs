

using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlVisibleCommand : Command
{
    private readonly Model.Abstract.Control _control;
    
    public ControlVisibleCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public override void Execute()
    {
        _control.Show();
    }
}