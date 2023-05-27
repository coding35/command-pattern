using CommandPattern.Implementation.Command;
using CommandPattern.Interface;

namespace CommandPattern.Implementation.Control;

public class ActionControl
{
    private readonly List<ICommand>? _commands = new();

    public void SetCommand(ICommand? command)
    {
        _commands!.Add(command!);
    }

    public void SetCommand(Func<ICommand?> commandList)
    {
        _commands!.Add(commandList() ?? new NoCommand());
    }

    public void OnPageLoad()
    {
        foreach (var command in _commands!)
        {
            command.Execute();
        }
    }
}