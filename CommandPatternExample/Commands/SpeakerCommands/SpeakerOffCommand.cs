public class SpeakerOffCommand(Speaker speaker) : ICommand
{
    private readonly Speaker TargetSpeaker = speaker;
    public void Execute()
    {
        TargetSpeaker.Off();
    }
}