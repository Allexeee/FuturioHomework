namespace FuturioHomework
{
  public interface ICommandMoveEndable
  {
    UObject        UObject { get; }
    ICommand       Command { get; }
    IQueueCommands Queue   { get; }
  }
}