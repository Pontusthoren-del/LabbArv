using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Car:Vehicle
    {
        public bool HasSunroof { get; set; }
        public Car() : base()
        {
            Brand = "Volvo";
            Model = "XC60";
            MaxSpeed = 210;
            Doors = 4;
            Gasoline = true;
            HasSunroof = false;
        }

        public Car(string brand, string model, int maxspeed, int doors, bool gasoline, bool hassunroof) : base(brand, model, maxspeed, doors, gasoline)
        {
            HasSunroof = hassunroof;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} sounds VROOOOOOOOOOWM.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Amount of doors : {Doors}");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
            Console.WriteLine($"Does it have a sunroof: {HasSunroof}.");
        }
    }
}
