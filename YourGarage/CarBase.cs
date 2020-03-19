using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class CarBase : VehicleBase
    {
        public override int fuelCapacity { get; set; }
        public override int passengerCount { get; set; }
        public override string vehicleColor { get; set; }

        public override void Refuel(string car)
        {
            Console.WriteLine($"Time to refuel");
        }

        public void Drive()
        {
            Console.WriteLine("Time to drive!");
        }

    }
}
