namespace FuturioHomework
{
  public class CommandRotateStart : ICommand
  {
    ICommandRotateStartable _startable;

    public CommandRotateStart(ICommandRotateStartable startable)
    {
      _startable    = startable;
      CommandRotate = new CommandBridge(new CommandRotate(new AdapterRotate(_startable.UObject)));
    }

    public ICommandInjectable CommandRotate { get; }

    public void Execute()
    {
      new CommandSetAngle(new AdapterSetAngle(_startable.UObject, _startable.Angle)).Execute();
      new CommandSetAngular(new AdapterSetAngular(_startable.UObject, _startable.Angular)).Execute();
      _startable.Queue.Add((ICommand) CommandRotate);
    }
  }
}