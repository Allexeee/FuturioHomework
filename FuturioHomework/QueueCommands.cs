using System.Collections.Generic;

namespace FuturioHomework
{
  public class QueueCommands : IQueueCommands
  {
    Queue<ICommand> _commands = new Queue<ICommand>();

    public void Add(ICommand command)
    {
      _commands.Enqueue(command);
    }
  }
}