namespace FuturioHomework
{
  public class CommandEnd : ICommand
  {
    ICommandEndable _startable;

    public CommandEnd(ICommandEndable startable)
    {
      _startable = startable;
    }

    public void Execute()
    {
      _startable.CommandRotateEnd.Execute();
      _startable.CommandMoveEnd.Execute();
    }
  }
}