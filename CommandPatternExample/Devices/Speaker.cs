public class Speaker(string name){
    private readonly string Name = name;

    public void On(){
        Console.WriteLine("{0} Speaker switched on!", Name);
    }

    public void Off(){
        Console.WriteLine("{0} Speaker switched off!", Name);
    }
}