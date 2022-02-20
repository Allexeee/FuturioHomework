namespace FuturioHomework
{
  public class CommandRotate : ICommand
  {
    IRotatable _rotatable;

    public CommandRotate(IRotatable rotatable)
    {
      _rotatable = rotatable;
    }

    public void Execute()
    {
      _rotatable.Angle += _rotatable.AngularVelocity;
    }
  }
}