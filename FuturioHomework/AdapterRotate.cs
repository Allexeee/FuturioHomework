using static FuturioHomework.Index;

namespace FuturioHomework
{
  public class AdapterRotate : IRotatable
  {
    UObject _uObject;

    public AdapterRotate(UObject uObject)
    {
      _uObject = uObject;
    }

    public int Angle
    {
      get => (int) _uObject[k_Angle];
      set => _uObject[k_Angle] = value;
    }

    public int AngularVelocity => (int) _uObject[k_Angular];
  }
}