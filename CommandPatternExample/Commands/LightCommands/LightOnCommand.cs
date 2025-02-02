public class LightOnCommand(Light light) : ICommand
{
    private readonly Light TargetLight = light;
    public void Execute()
    {
        TargetLight.On();
    }
}