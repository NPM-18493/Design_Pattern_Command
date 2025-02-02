public class SpeakerOnCommand(Speaker speaker) : ICommand
{
    private readonly Speaker TargetSpeaker = speaker;
    public void Execute()
    {
        TargetSpeaker.On();
    }
}