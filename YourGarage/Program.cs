using System;
using YourGarage.TheAircrafts;
using YourGarage.TheCars;
using YourGarage.TheWatercrafts;
using System.Collections.Generic;

namespace YourGarage
{
    class Program
    {   
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()

            var airplane = new KingJet(200, "White", 9);
            var helecopter = new BlackHawk(150, "Black", 5);

            List<Aircraft> aircrafts = new List<Aircraft>();
            aircrafts.Add(airplane);
            aircrafts.Add(helecopter);

            foreach (var aircraft in aircrafts)
            {
                aircraft.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            var audi = new Audi("Snow White", 32, 5);
            var tesla = new Tesla("Black", 0, 5);

            List<CarBase> cars = new List<CarBase>();
            cars.Add(audi);
            cars.Add(tesla);

            foreach (var car in cars)
            {
                car.Drive();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()

            var speed = new Speedboat(100, "Blue", 7);
            var jetski = new Jetski(20, "Yellow", 2);

            List<Watercraft> boats = new List<Watercraft>();
            boats.Add(speed);
            boats.Add(jetski);

            foreach (var boat in boats)
            {
                boat.Driving();
            }
            Console.ReadLine();
        }
    }
}
