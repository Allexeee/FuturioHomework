namespace FuturioHomework
{
  public class CommandMoveStart : ICommand
  {
    ICommandMoveStartable _startable;

    public CommandMoveStart(ICommandMoveStartable startable)
    {
      _startable = startable;
    }

    public void Execute()
    {
      new CommandSetVelocity(new AdapterSetVelocity(_startable.UObject, _startable.Velocity)).Execute();
      _startable.Queue.Add(new CommandMove(new AdapterMove(_startable.UObject)));
    }
  }
}