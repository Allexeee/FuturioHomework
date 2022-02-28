using System.Numerics;

namespace FuturioHomework
{
  public class AdapterRotate : IRotatable
  {
    UObject _uObject;

    public AdapterRotate(UObject uObject)
    {
      _uObject = uObject;
    }
    
    public float Angle
    {
      get => _uObject.Angle;
      set => _uObject.Angle = value;
    }

    public float AngularVelocity => _uObject.AngularVelocity;
  }
}