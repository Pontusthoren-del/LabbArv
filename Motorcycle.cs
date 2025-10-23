using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Motorcycle:Vehicle
    {
        public bool HasSideCar { get; set; }
        public Motorcycle() : base()
        {
            Brand = "Yamaha";
            Model = "MT-07";
            MaxSpeed = 220;
            Doors = 0;
            Gasoline = true;
            HasSideCar = false;
        }

        public Motorcycle(string brand, string model, int maxspeed, bool gasoline,bool hassidecar) : base(brand, model, maxspeed,0, gasoline)
        {
            HasSideCar = hassidecar;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} sounds YAAAAAAAHAAAMAAAAHAAAAAA.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
            Console.WriteLine($"Does it has a sidecar: {HasSideCar}.");
        }
    }
}
