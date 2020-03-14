using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class VehicleBase
    {
        public virtual int fuelCapacity { get; set; }
        public virtual string vehicleColor { get; set; }
        public virtual int passengerCount { get; set; }

        public abstract void Refuel();

    }
}
