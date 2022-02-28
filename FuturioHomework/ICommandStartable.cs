namespace FuturioHomework
{
  public interface ICommandStartable
  {
    ICommand CommandMoveStart   { get; }
    ICommand CommandRotateStart { get; }
  }
}