namespace FuturioHomework
{
  class AdapterMoveEnd : ICommandMoveEndable
  {
    public AdapterMoveEnd(UObject uObject, ICommandInjectable command)
    {
      UObject = uObject;
      Command = command;
    }

    public UObject            UObject { get; }
    public ICommandInjectable Command { get; }
  }
}