namespace Module01Pract01;

public class Program
{
    public static void Main()
    {
        Car car1 = new Car(2020, "Camry75", "Toyota", 4, "Automatic");
        Car car2 = new Car(1993, "Forester", "Subaru", 5, "Manual");
        Motorcycle moto = new Motorcycle(2019, "R1", "Yamaha", "Sportbyke", false);

        Garage garage1 = new Garage(1);
        garage1.AddVehicle(car1);
        garage1.AddVehicle(moto);

        Garage garage2 = new Garage(1);
        garage2.AddVehicle(car2);

        Fleet fleet = new Fleet();
        fleet.AddGarage(garage1);
        fleet.AddGarage(garage2);

       garage1.CheckList();
       Console.WriteLine("-------------------");
        garage2.CheckList();

        var foundGarage =  fleet.SearchVehicle(car2);
        if (foundGarage != null)
        {
            Console.WriteLine($"Car {car2.Model} has been founded in garage #{foundGarage.id}");
        }
        foundGarage = fleet.SearchVehicle(moto);
        if (foundGarage != null)
        {
            Console.WriteLine($"Byke {moto.Model} has been founded in garage #{foundGarage.id}");
        }
        
    }
}
