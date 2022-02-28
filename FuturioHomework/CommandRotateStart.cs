namespace FuturioHomework
{
  public class CommandRotateStart : ICommand
  {
    ICommandRotateStartable _startable;

    public CommandRotateStart(ICommandRotateStartable startable)
    {
      _startable = startable;
    }

    public void Execute()
    {
      new CommandSetAngle(new AdapterSetAngle(_startable.UObject, _startable.Angle)).Execute();
      new CommandSetAngular(new AdapterSetAngular(_startable.UObject, _startable.Angular)).Execute();
      _startable.Queue.Add(new CommandRotate(new AdapterRotate(_startable.UObject)));
    }
  }
}