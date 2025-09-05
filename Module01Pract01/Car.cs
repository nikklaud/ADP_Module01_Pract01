namespace Module01Pract01;

public class Car: Vehicle
{
    public int CountOfDoors { get; }
    public string TypeOfTransmission { get; }

    public Car(int year, string model, string mark, int countOfDoors, string typeOfTransmission) : base(year, model, mark)
    {
        CountOfDoors = countOfDoors;
        TypeOfTransmission = typeOfTransmission;
    }
}