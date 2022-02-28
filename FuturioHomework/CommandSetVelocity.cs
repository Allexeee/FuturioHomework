namespace FuturioHomework
{
  public class CommandSetVelocity : ICommand
  {
    IVelocitySettable _settable;

    public CommandSetVelocity(IVelocitySettable settable)
    {
      _settable = settable;
    }

    public void Execute()
    {
      _settable.Velocity = _settable.NewValue;
    }
  }
}