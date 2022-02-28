﻿using System;
using System.Numerics;
using System.Threading;
using static FuturioHomework.Index;

namespace FuturioHomework
{
  class Program
  {
    static void Main(string[] args)
    {
      var obj = new UObject();
      obj[k_Position] = new Vector2(0, 0);

      var queue     = new QueueCommandsExample();
      var spaceShip = new SpaceShip(obj, queue);

      while (true)
      {
        queue.Execute();
        spaceShip.Execute();

        Console.WriteLine($"Time: {GameTime.Current} Pos: {obj[k_Position]}");
        Thread.Sleep(GameTime.DeltaM);
        GameTime.Current += GameTime.Delta;
      }
    }
  }

  public class GameTime
  {
    public const  int   DeltaM = 300;
    public const  float Delta  = DeltaM / 1000f;
    public static float Current;
  }

  public class SpaceShip : ICommand
  {
    UObject        _obj;
    IQueueCommands _queue;

    int                _state;
    ICommandInjectable _commandRotate;
    ICommandInjectable _commandMove;

    public SpaceShip(UObject obj, IQueueCommands queue)
    {
      _obj   = obj;
      _queue = queue;
      var commandMoveStart   = new CommandMoveStart(new AdapterMoveStart(_obj, _queue, 1));
      var commandRotateStart = new CommandRotateStart(new AdapterRotateStart(_obj, queue, 0, 1));
      _commandMove   = commandMoveStart.CommandMove;
      _commandRotate = commandRotateStart.CommandRotate;
      new CommandStart(new AdapterStart(commandMoveStart, commandRotateStart)).Execute();
    }

    public void Execute()
    {
      if (GameTime.Current < 5f)
        return;
      TrySetState(1);
      if (GameTime.Current < 10f)
        return;
      TrySetState(2);
    }

    void TrySetState(int state)
    {
      if (state <= _state) 
        return;

      _state = state;

      switch (_state)
      {
        case 1:
          var commandMoveEnd   = new CommandMoveEnd(new AdapterMoveEnd(_obj, _commandMove));
          var commandRotateEnd = new CommandRotateEnd(new AdapterRotateEnd(_obj, _commandRotate));
          new CommandEnd(new AdapterEnd(commandMoveEnd, commandRotateEnd)).Execute();
          break;
        case 2:
          new CommandSetAngle(new AdapterSetAngle(_obj, 0)).Execute();
          new CommandMoveStart(new AdapterMoveStart(_obj, _queue, 1)).Execute();
          break;
      }
    }
  }
}