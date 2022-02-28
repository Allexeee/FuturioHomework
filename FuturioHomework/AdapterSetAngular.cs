using static FuturioHomework.Index;

namespace FuturioHomework
{
  public class AdapterSetAngular : IAngularSettable
  {
    UObject _uObject;

    public AdapterSetAngular(UObject uObject, int newValue)
    {
      _uObject = uObject;
      NewValue = newValue;
    }

    public int Value
    {
      set => _uObject[k_Angular] = value;
    }

    public int NewValue { get; }
  }
}