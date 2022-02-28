namespace FuturioHomework
{
  public interface ICommandMoveStartable
  {
    UObject        UObject  { get; }
    int            Velocity { get; }
    IQueueCommands Queue    { get; }
  }
}