namespace FuturioHomework
{
  public class CommandBridge : ICommand, ICommandInjectable
  {
    ICommand _command;
    
    public CommandBridge(ICommand command)
    {
      _command = command;
    }

    public void Execute()
    {
      _command.Execute();
    }

    public void Inject(ICommand other)
    {
      _command = other;
    }
  }
}