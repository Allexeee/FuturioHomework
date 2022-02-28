namespace FuturioHomework
{
  class AdapterStart : ICommandStartable
  {
    public AdapterStart(ICommand commandMoveStart, ICommand commandRotateStart)
    {
      CommandMoveStart   = commandMoveStart;
      CommandRotateStart = commandRotateStart;
    }

    public ICommand CommandMoveStart   { get; }
    public ICommand CommandRotateStart { get; }
  }
}