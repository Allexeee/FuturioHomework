namespace FuturioHomework
{
  public class CommandSetAngular : ICommand
  {
    IAngularSettable _settable;

    public CommandSetAngular(IAngularSettable settable)
    {
      _settable = settable;
    }

    public void Execute()
    {
      _settable.Value = _settable.NewValue;
    }
  }
}