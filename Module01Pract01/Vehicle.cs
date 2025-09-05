namespace Module01Pract01;

public class Vehicle
{
    public int Year {get; }
    public string Model {get; }
    public string Mark {get; }

    public void StartEngine()
    {
        Console.WriteLine("Engine start");
    }

    public void StopEngine()
    {
        Console.WriteLine("5 minutes ti din ti din engine kaput");
    }

    public Vehicle(int year, string model, string mark)
    {
        this.Year = year;
        this.Model = model;
        this.Mark = mark;
    }
}