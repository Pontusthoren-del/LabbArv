using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int Doors { get; set; }
        public bool Gasoline { get; set; }

        public Vehicle(string brand, string model, int maxspeed, int doors, bool gasoline)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxspeed;
            Doors = doors;
            Gasoline = gasoline;
        }
        public Vehicle()
        {
            Brand = "Brand";
            Model = "Model";
            MaxSpeed = 100;
            Doors = 4;
            Gasoline = true;
        }

        public void StartVehicle()
        {
            Console.WriteLine($"{Brand} {Model} starts the engine.");
        }
        public virtual void StartEngine()
        {
            Console.WriteLine($"Vehicle sounds VRRROOOOOOOWM.");
        }
        public void StopVehicle()
        {
            Console.WriteLine($"{Brand} {Model} shuts off the engine.");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Amount of doors : {Doors}");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
        }
    }
}
