using System;
using System.Numerics;
using static FuturioHomework.Index;

namespace FuturioHomework
{
  public class AdapterMove : IMovable
  {
    UObject _uObject;

    public AdapterMove(UObject uObject)
    {
      _uObject = uObject;
    }

    public Vector2 Position
    {
      get => (Vector2) _uObject[k_Position];
      set => _uObject[k_Position] = value;
    }

    public Vector2 Velocity => CalculateVelocity();

    Vector2 CalculateVelocity()
    {
      var speed   = (int) _uObject[k_Velocity];
      var angle   = (int) _uObject[k_Angle];
      var radians = angle * MathF.PI / 180f;
      var x       = MathF.Cos(radians);
      var y       = MathF.Sin(radians);

      var result = new Vector2(x, y) * speed;
      return result;
    }
  }
}