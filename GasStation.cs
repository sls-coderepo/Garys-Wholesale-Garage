using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public class GasStation : IRefillStation<GasVehicle>
    {
        public int Capacity { get; set; }

        public void Refuel(List<GasVehicle> vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"The {vehicle.Name} has been refuled with {vehicle.FuelCapacity} gallons of gas");
            }
        }
    }
}