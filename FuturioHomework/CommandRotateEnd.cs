using static FuturioHomework.Index;

namespace FuturioHomework
{
  public class CommandRotateEnd : ICommand
  {
    ICommandRotateEndable _endable;

    public CommandRotateEnd(ICommandRotateEndable endable)
    {
      _endable = endable;
    }

    public void Execute()
    {
      _endable.UObject.Remove(k_Angular);
      _endable.Command.Inject(CommandEmpty.Default);
    }
  }
}