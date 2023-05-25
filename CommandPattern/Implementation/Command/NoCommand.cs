using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

/// <summary>
/// A null object is useful when you don’t have a meaningful object to return,
/// and yet you want to remove the responsibility for handling null from the client.
/// </summary>
public class NoCommand : ICommand
{
    public void Execute()
    {
        // Do nothing
    }
}