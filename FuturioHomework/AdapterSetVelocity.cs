using static FuturioHomework.Index;

namespace FuturioHomework
{
  public class AdapterSetVelocity : IVelocitySettable
  {
    UObject _uObject;

    public AdapterSetVelocity(UObject uObject, int newValue)
    {
      _uObject = uObject;
      NewValue = newValue;
    }

    public int Velocity
    {
      set => _uObject[k_Velocity] = value;
    }

    public int NewValue { get; }
  }
}