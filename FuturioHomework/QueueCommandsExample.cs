using System.Collections.Generic;

namespace FuturioHomework
{
  public class QueueCommandsExample : ICommand, IQueueCommands
  {
    List<ICommand> _commands = new List<ICommand>();

    public void Add(ICommand command)
    {
      _commands.Add(command);
    }

    public void Execute()
    {
      foreach (var command in _commands) 
        command.Execute();
    }
  }
}