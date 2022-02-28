namespace FuturioHomework
{
  public class CommandMoveEnd : ICommand
  {
    ICommandMoveEndable _endable;

    public CommandMoveEnd(ICommandMoveEndable endable)
    {
      _endable = endable;
    }

    public void Execute()
    {
      _endable.UObject.Remove(Index.k_Velocity);
      _endable.Command.Inject(CommandEmpty.Default);
    }
  }
}