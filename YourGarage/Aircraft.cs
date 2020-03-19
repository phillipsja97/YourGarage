using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft : VehicleBase
    {
        public string Make { get; set; }
        public bool Private { get; set; }
        public bool rotaryEngine { get; set; }

        public void Fly()
        {
            Console.WriteLine($"The aircraft is flying!");
        }

        public override void Refuel(string car)
        {
            Console.WriteLine($"The {car} is refueling.");
        }
    }
}
