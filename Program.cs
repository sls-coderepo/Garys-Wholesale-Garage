using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {

            GasVehicle murano = new GasVehicle("Murano", 18);
            GasVehicle rouge = new GasVehicle("Rouge", 16);
            GasVehicle accord = new GasVehicle("Accord", 23);
            List<GasVehicle> gasVehicleList = new List<GasVehicle>()
            {
                murano,
                rouge,
                accord
            };

            GasStation gasStation = new GasStation();
            gasStation.Refuel(gasVehicleList);

            ElectricVehicle tesla = new ElectricVehicle("Tesla", 5);
            ElectricVehicle nissan = new ElectricVehicle("Leaf", 5);
            List<ElectricVehicle> electricVehicleList = new List<ElectricVehicle>()
            {
                tesla,
                nissan
            };

            BatteryStation electricStation = new BatteryStation();
            electricStation.Refuel(electricVehicleList);

        }
    }
}