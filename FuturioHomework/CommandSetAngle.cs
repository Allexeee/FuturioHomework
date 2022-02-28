namespace FuturioHomework
{
  public class CommandSetAngle : ICommand
  {
    IAngleSettable _settable;

    public CommandSetAngle(IAngleSettable settable)
    {
      _settable = settable;
    }

    public void Execute()
    {
      _settable.Value = _settable.NewValue;
    }
  }
}