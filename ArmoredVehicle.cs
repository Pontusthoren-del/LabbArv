using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class ArmoredVehicle:Car
    {
        public bool HasArmor { get; set; }

        public ArmoredVehicle() : base()
        {
            Brand = "Armata";
            Model = "T-14";
            MaxSpeed = 90;
            Doors = 1;
            Gasoline = true;
            HasArmor = true;
        }

        public ArmoredVehicle(string brand, string model, int maxspeed, bool gasoline, bool hasarmor) : base(brand, model, maxspeed, 0, gasoline, true)
        {
            HasArmor = hasarmor;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} {Model} starts its engine: GRRROOOOOMMM... heavy metal rumble!");
        }
       
        public override void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
            Console.WriteLine($"Does it have armor: {HasArmor}.");
        }
        public void ShotTurret()
        {
            Console.WriteLine("Do you want to fire the cannon? Yes/No.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "yes")
            {
            Console.WriteLine($"{Brand} {Model} fires the cannon: BANG! BOOM! Target destroyed! 💥");
            }
            else
            {
                Console.WriteLine($"{Brand} has no target in sight.");
            }
        }
    }
}
