namespace FuturioHomework
{
  public interface ICommandMoveEndable
  {
    UObject        UObject { get; }
    ICommandInjectable       Command { get; }
    // IQueueCommands Queue   { get; }
  }
}