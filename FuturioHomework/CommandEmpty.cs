namespace FuturioHomework
{
  public class CommandEmpty : ICommand
  {
    public static readonly CommandEmpty Default = new CommandEmpty();
    
    public void Execute()
    {
    }
  }
}