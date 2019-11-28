namespace GarysWholesaleGarage
{
    public class GasVehicle
    {
        public string Name { get; set; }
        public int FuelCapacity { get; set; }
        public GasVehicle(string name, int fuelCapacity)
        {
            Name = name;
            FuelCapacity = fuelCapacity;
        }

    }
}