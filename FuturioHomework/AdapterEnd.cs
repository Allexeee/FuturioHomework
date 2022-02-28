namespace FuturioHomework
{
  class AdapterEnd : ICommandEndable
  {
    public AdapterEnd(ICommand commandMoveEnd, ICommand commandRotateEnd)
    {
      CommandMoveEnd   = commandMoveEnd;
      CommandRotateEnd = commandRotateEnd;
    }

    public ICommand CommandMoveEnd   { get; }
    public ICommand CommandRotateEnd { get; }
  }
}