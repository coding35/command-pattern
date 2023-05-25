using CommandPattern.Interface;

namespace CommandPattern.Implementation.Control;

public class ActionControl
{
    ICommand? _command;

    
    public void SetCommand(ICommand? command)
    {
        _command = command;
    }
    
    public void OnPageLoad()
    {
        _command?.Execute();

    }
}