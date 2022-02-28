namespace FuturioHomework
{
  public class CommandStart : ICommand
  {
    ICommandStartable _startable;

    public CommandStart(ICommandStartable startable)
    {
      _startable = startable;
    }

    public void Execute()
    {
      _startable.CommandRotateStart.Execute();
      _startable.CommandMoveStart.Execute();
    }
  }
}