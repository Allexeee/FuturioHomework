using System;
using System.Numerics;

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
      get => _uObject.Position;
      set => _uObject.Position = value;
    }

    public Vector2 Velocity => CalculateVelocity();

    Vector2 CalculateVelocity()
    {
      var speed = _uObject.Speed;
      var radians     = _uObject.Angle * MathF.PI / 180f;
      var x     = MathF.Cos(radians);
      var y     = MathF.Sin(radians);

      var result = new Vector2(x, y) * speed;
      return result;
    }
  }
}