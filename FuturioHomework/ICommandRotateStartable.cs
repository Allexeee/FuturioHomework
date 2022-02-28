namespace FuturioHomework
{
  public interface ICommandRotateStartable
  {
    UObject        UObject { get; }
    int            Angle   { get; }
    int            Angular { get; }
    IQueueCommands Queue   { get; }
  }
}