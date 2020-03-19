using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.TheAircrafts
{
    class BlackHawk : Aircraft
    {
        public BlackHawk(int fuel, string color, int passengers)
        {
            fuelCapacity = fuel;
            vehicleColor = color;
            passengerCount = passengers;
        }

        public override void Refuel(string helo)
        {
            Console.WriteLine($"{helo} is refueling.");
        }
        public void Fly()
        {
            Console.WriteLine($"The {vehicleColor} helo flys away.");
        }
    }
}
