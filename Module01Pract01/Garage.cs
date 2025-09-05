using System.Collections;

namespace Module01Pract01;

public class Garage : IEnumerable
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        this.vehicles.Add(vehicle);
        Console.WriteLine($"Vehicle {vehicle.Model} has been added");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        this.vehicles.Remove(vehicle);
        Console.WriteLine($"Vehicle {vehicle.Model} has been removed");
    }

    public void CheckList()
    {
        foreach (var vehicle in this.vehicles)
        {
            Console.WriteLine(vehicle.Model);
        }
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}