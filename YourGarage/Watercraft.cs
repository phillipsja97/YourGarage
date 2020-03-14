using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Watercraft : VehicleBase
    {
        public override void Refuel()
        {
            Console.WriteLine(" Watercraft Refuel");
        }

        public void Driving()
        {
            Console.WriteLine($"Drive the thing");
        }
    }
}
