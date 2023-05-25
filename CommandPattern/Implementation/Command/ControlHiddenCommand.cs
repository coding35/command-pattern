using CommandPattern.Interface;
using CommandPattern.Model.Abstract;

namespace CommandPattern.Implementation.Command;

public class ControlHiddenCommand : ICommand
{
    private readonly Model.Abstract.Control _control;
    
    public ControlHiddenCommand(Model.Abstract.Control control)
    {
        _control = control;
    }
    
    public void Execute()
    {
        _control.Hide();
    }
}