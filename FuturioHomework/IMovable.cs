using System.Numerics;

namespace FuturioHomework
{
  public interface IMovable
  {
    Vector2 Position { get; set; }
    Vector2 Velocity { get; }
  }
}