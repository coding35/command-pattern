

using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public class ControlVisibleCommand : ICommand
{
    private readonly Model.Abstract.Control _control;
    
    public ControlVisibleCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public void Execute()
    {
        _control.Show();
    }
}