using System;
using System.Collections.Generic;
using System.Numerics;

namespace FuturioHomework
{
  public class UObject
  {
    public Dictionary<string, object> Values { get; } = new Dictionary<string, object>();

    public Vector2 Position
    {
      get => (Vector2) Values["Position"];
      set => Values["Position"] = value;
    }

    public float Speed
    {
      get => (float) Values["Speed"];
      set => Values["Speed"] = value;
    }

    public float Angle
    {
      get => (float) Values["Angle"];
      set => Values["Angle"] = value;
    }

    public float AngularVelocity
    {
      get => (float) Values["AngularVelocity"];
      set => Values["AngularVelocity"] = value;
    }
  }
}