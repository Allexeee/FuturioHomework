namespace FuturioHomework
{
  public interface ICommandRotateEndable
  {
    UObject        UObject { get; }
    ICommand       Command { get; }
    IQueueCommands Queue   { get; }
  }
}