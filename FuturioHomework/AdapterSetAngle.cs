using static FuturioHomework.Index;

namespace FuturioHomework
{
  public class AdapterSetAngle : IAngleSettable
  {
    UObject _uObject;

    public AdapterSetAngle(UObject uObject, int newValue)
    {
      _uObject = uObject;
      NewValue = newValue;
    }
    

    public int Value
    {
      set => _uObject[k_Angle] = value;
    }

    public int NewValue { get; }
  }
}