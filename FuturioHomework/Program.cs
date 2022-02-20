using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace FuturioHomework
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var obj = new UObject()
      {
        Position        = new Vector2(50, 50),
        Speed = 1f,
        Angle           = 0,
        AngularVelocity = 45,
      };
      var commandMove = new CommandMove(new AdapterMove(obj));
      var commandRotate = new CommandRotate(new AdapterRotate(obj));

      while (true)
      {
        commandMove.Execute();
        commandRotate.Execute();
        
        Console.WriteLine($"Pos: {obj.Position} Angle: {obj.Angle}");
        Thread.Sleep(300);
      }
    }
  }
}