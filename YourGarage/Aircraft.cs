using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft : VehicleBase
    {
        public override void Refuel()
        {
            Console.WriteLine($"Aircraft Refueling");
        }
    }
}
