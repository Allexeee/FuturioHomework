namespace FuturioHomework
{
  public class CommandMove : ICommand
  {
    IMovable _movable;

    public CommandMove(IMovable movable)
    {
      _movable = movable;
    }

    public void Execute()
    {
      _movable.Position += _movable.Velocity;
    }
  }
}