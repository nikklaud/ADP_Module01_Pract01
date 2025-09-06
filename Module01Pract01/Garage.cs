using System.Collections;

namespace Module01Pract01;

public class Garage 
{
    public readonly List<Vehicle> Vehicles = new List<Vehicle>();
    public int id {get; }

    public void AddVehicle(Vehicle vehicle)
    {
        this.Vehicles.Add(vehicle);
        Console.WriteLine($"Vehicle {vehicle.Model} has been added");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        this.Vehicles.Remove(vehicle);
        Console.WriteLine($"Vehicle {vehicle.Model} has been removed");
    }

    public Garage(int id)
    {
        this.id = id;
    }

    public void CheckList()
    {
        foreach (var vehicle in this.Vehicles)
        {
             Console.WriteLine(vehicle.Model);
        }
    }
}