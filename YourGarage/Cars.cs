using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Cars : VehicleBase
    {
        public string carMake { get; set; }
        public bool isLuxury { get; set; }
        public bool isfourByFour { get; set; }
        public List<string> AllTheCars = new List<string>();
        public Cars(string make)
        {
            carMake = make;
            AllTheCars.Add(make);

        }
        public override void Refuel()
        {
            Console.WriteLine($"Refueling");
        }

    }
}
