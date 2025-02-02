using System.Linq;

public class RemoteControl
{
    public ICommand[] OnCommands;
    public ICommand[] OffCommands;

    public RemoteControl()
    {
        NoCommand noCommand = new NoCommand();

        OnCommands = new ICommand[4];
        OffCommands = new ICommand[4];
        for (int i = 0; i < 2; i++)
        {
            OnCommands[i] = noCommand;
            OffCommands[i] = noCommand;
        }
    }

    public void AddOnCommand(int slot, ICommand onCommand)
    {
        OnCommands[slot] = onCommand;
    }

    public void AddOffCommand(int slot, ICommand offCommand)
    {
        OffCommands[slot] = offCommand;
    }

    public void PressOnButton(int slot)
    {
        OnCommands[slot].Execute();
    }

    public void PressOffButton(int slot)
    {
        OffCommands[slot].Execute();
    }
}