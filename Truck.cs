using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Truck:Vehicle
    {
        public int LoadCapacity { get; set; }
        public Truck() : base()
        {
            Brand = "Volvo";
            Model = "FH";
            MaxSpeed = 120;
            Doors = 2;
            Gasoline = true;
            LoadCapacity = 10;
        }

        public Truck(string brand, string model, int maxspeed, int doors, bool gasoline, int loadcapacity) : base(brand, model, maxspeed, doors, gasoline)
        {
            LoadCapacity = loadcapacity;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} sounds BRRRRUUUUUUUUUUWWWM.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Amount of doors : {Doors}");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
            Console.WriteLine($"Load Capacity: {LoadCapacity} tons..");
        }
    }
}
