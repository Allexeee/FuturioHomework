using System;
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
      obj[k_Position] = new Vector2(50, 50);
      obj[k_Velocity] = 1;
      obj[k_Angle]    = 0;
      obj[k_Angular]  = 45;
      var commandMove   = new CommandMove(new AdapterMove(obj));
      var commandRotate = new CommandRotate(new AdapterRotate(obj));

      while (true)
      {
        commandMove.Execute();
        commandRotate.Execute();

        Console.WriteLine($"Pos: {obj[k_Position]} Angle: {obj[k_Angle]}");
        Thread.Sleep(300);
      }
    }
  }
}