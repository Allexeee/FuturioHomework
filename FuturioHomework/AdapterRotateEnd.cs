namespace FuturioHomework
{
  class AdapterRotateEnd : ICommandRotateEndable
  {
    public AdapterRotateEnd(UObject uObject, ICommandInjectable command)
    {
      UObject = uObject;
      Command = command;
    }

    public UObject            UObject { get; }
    public ICommandInjectable Command { get; }
  }
}