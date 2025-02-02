public class Light(string name){
    private readonly string Name = name;

    public void On(){
        Console.WriteLine("{0} light switched on!", Name);
    }

    public void Off(){
        Console.WriteLine("{0} light switched off!", Name);
    }
}