using System.Collections.Generic;

namespace FuturioHomework
{
  public class UObject
  {
    Dictionary<string, object> _values { get; } = new Dictionary<string, object>();

    public object this[string key]
    {
      get => _values[key];
      set => _values[key] = value;
    }

    public void Remove(string key)
    {
      _values.Remove(key);
    }
  }
}