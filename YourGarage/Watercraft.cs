using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Watercraft : VehicleBase
    {
        public string Make { get; set; }
        public int NumberOfEngines { get; set; }
        public bool fishingBoat { get; set; }
        public override void Refuel(string watercraft)
        {
            Console.WriteLine(" Watercraft Refuel");
        }

        public void Driving()
        {
            Console.WriteLine($"Drive the thing");
        }
    }
}
