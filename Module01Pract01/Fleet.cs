namespace Module01Pract01;

public class Fleet
{
    private readonly List<Garage> garages = new List<Garage>();

    public void AddGarage(Garage garage)
    {
        garages.Add(garage);
    }

    public void RemoveGarage(Garage garage)
    {
        garages.Remove(garage);
    }

    public Garage SearchVehicle(Vehicle vehicle)
    {
        foreach (var garage in garages)
        {
            foreach (var v in garage)
            {
                if (v.Model == vehicle.Model)
                {
                    return garage;
                }
            }
        }
    }
}