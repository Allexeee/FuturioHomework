namespace FuturioHomework
{
  class AdapterMoveStart : ICommandMoveStartable
  {
    public AdapterMoveStart(UObject uObject, IQueueCommands queue, int velocity)
    {
      UObject  = uObject;
      Velocity = velocity;
      Queue    = queue;
    }

    public UObject        UObject  { get; }
    public int            Velocity { get; }
    public IQueueCommands Queue    { get; }
  }
}