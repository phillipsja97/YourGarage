using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.TheCars
{
    class Audi : CarBase
    {
        public Audi(string color, int fuel, int passengers)
        {
            fuelCapacity = fuel;
            vehicleColor = color;
            passengerCount = passengers;
        }

        public void Drive()
        {
            Console.WriteLine($"The {vehicleColor} car drives down the road.");
        }
    }
}
