namespace GarysWholesaleGarage
{
    public class ElectricVehicle
    {
        public string Name { get; set; }
        public int FuelCapacity { get; set; }
        public ElectricVehicle(string name, int fuelCpacity)
        {
            Name = name;
            FuelCapacity = fuelCpacity;
        }
    }
}