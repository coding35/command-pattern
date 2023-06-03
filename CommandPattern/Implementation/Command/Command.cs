using CommandPattern.Interface;

namespace CommandPattern.Implementation.Command;

public abstract class Command : ICommand
{
    public abstract void Execute();
    
}