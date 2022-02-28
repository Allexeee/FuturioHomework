namespace FuturioHomework
{
  public interface ICommandEndable
  {
    ICommand CommandMoveEnd   { get; }
    ICommand CommandRotateEnd { get; }
  }
}