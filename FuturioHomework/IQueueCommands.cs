﻿using System.Collections.Generic;

namespace FuturioHomework
{
  public interface IQueueCommands
  {
    void Add(ICommand    command);
    void Remove(ICommand command);
  }

  public class QueueCommands : IQueueCommands
  {
    Queue<ICommand> _commands = new Queue<ICommand>();

    public void Add(ICommand command)
    {
      _commands.Enqueue(command);
    }

    public void Remove(ICommand command)
    {
      var commands = new ICommand[_commands.Count];
      var i        = 0;
      while (_commands.TryDequeue(out var c))
      {
        if(c == command) continue;
        commands[i++] = c;
      }

      for (var j = 0; j < i; j++)
      {
        _commands.Enqueue(commands[j]);
      }
    }
  }
}