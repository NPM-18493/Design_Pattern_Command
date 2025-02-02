public class LightOffCommand(Light light) : ICommand
{
    private readonly Light TargetLight = light;
    public void Execute()
    {
        TargetLight.Off();
    }
}