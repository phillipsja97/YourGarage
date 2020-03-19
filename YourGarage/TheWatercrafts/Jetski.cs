using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.TheWatercrafts
{
    class Jetski : Watercraft
    {
        public Jetski(int fuel, string color, int passengers)
        {
            fuelCapacity = fuel;
            vehicleColor = color;
            passengerCount = passengers;
        }

        public override void Refuel(string airplane)
        {
            Console.WriteLine($"{airplane} is refueling.");
        }
        public void Drive()
        {
            Console.WriteLine($"The {vehicleColor} car drives down the road.");
        }
    }
}
