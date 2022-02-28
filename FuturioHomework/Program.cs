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
}