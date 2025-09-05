namespace Module01Pract01;

public class Vehicle
{
    private int Year {get; set;}
    private string Model {get; set;}
    private string Mark {get; set;}

    public void StartEngine { get; }

    public Vehicle(int year, string model, string mark)
    {
        this.Year = year;
        this.Model = model;
        this.Mark = mark;
    }
    
}