namespace Module01Pract01;

public class Motorcycle: Vehicle
{
    public string TypeOfBody { get; }
    public bool HasBox { get; set; }

    public Motorcycle(int year, string model, string mark, string typeOfBody, bool hasBox) : base(year, model, mark)
    {
        TypeOfBody = typeOfBody;
        HasBox = hasBox;
    }
}