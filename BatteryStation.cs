using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public class BatteryStation : IRefillStation<ElectricVehicle>
    {
        public int Capacity { get; set; }

        public void Refuel(List<ElectricVehicle> vehicleList)
        {
            foreach (var vehicle in vehicleList)
            {
                Console.WriteLine($"The {vehicle.Name} has been charged with {vehicle.FuelCapacity} kw");
            }
        }
    }
}