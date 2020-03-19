using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.TheAircrafts
{
    class KingJet : Aircraft
    {
        public KingJet(int fuel, string color, int passengers)
        {
            fuelCapacity = fuel;
            vehicleColor = color;
            passengerCount = passengers;
        }

        public override void Refuel(string airplane)
        {
            Console.WriteLine($"{airplane} is refueling.");
        }
        public void Fly()
        {
            Console.WriteLine($"The {vehicleColor} plane flys away.");
        }
    }
}
