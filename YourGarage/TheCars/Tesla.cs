using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.TheCars
{
    class Tesla : CarBase
    {
        public Tesla(string color, int fuel, int passengers)
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
