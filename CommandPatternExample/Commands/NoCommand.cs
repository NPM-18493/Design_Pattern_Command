public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("No command implemented!");
    }
}