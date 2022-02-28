namespace FuturioHomework
{
  class AdapterRotateStart : ICommandRotateStartable
  {
    public AdapterRotateStart(UObject uObject, IQueueCommands queue, int angle, int angular)
    {
      UObject      = uObject;
      Queue        = queue;
      Angle        = angle;
      Angular = angular;
    }

    public UObject        UObject  { get; }
    public int            Angle    { get; }
    public int            Angular  { get; }
    public IQueueCommands Queue    { get; }
  }
}