namespace Module01Pract01;

public class Fleet
{
    private readonly List<Garage> _garages = new List<Garage>();

    public void AddGarage(Garage garage)
    {
        _garages.Add(garage);
    }

    public void RemoveGarage(Garage garage)
    {
        _garages.Remove(garage);
    }

    public Garage SearchVehicle(Vehicle vehicle)
    {
        foreach (var garage in _garages)
        {
            if (garage.Vehicles.Contains(vehicle))
            {
                return garage;
            }
        }
        return null;
    }
}