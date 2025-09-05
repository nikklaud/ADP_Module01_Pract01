namespace Module01Pract01;

class Program
{
    public static void Main(string[] args)
    {
        Vehicle v = new Vehicle(2000, "maybach", "mers");
        Vehicle v2 = new Vehicle(2001, "hello ", "jhsjs");
        Console.WriteLine("Hello World!");
        v.StartEngine();
        v.StopEngine();
        Console.WriteLine(v2.Model);
    }
}