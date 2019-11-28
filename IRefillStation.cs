using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public interface IRefillStation<T>
    {
        int Capacity { get; set; }
        void Refuel(List<T> vehicle);

    }
}