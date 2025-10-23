using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Limousin : Car
    {
        public bool HaveABar { get; set; }

        public Limousin() : base()
        {
            Brand = "Lincoln";
            Model = "Town Car Stretch";
            MaxSpeed = 180;
            Doors = 6;
            Gasoline = true;
            HaveABar = true;
        }

        public Limousin(string brand, string model, int maxspeed, bool gasoline, bool haveabar) : base(brand, model, maxspeed, 0, gasoline, true)
        {
            HaveABar = haveabar;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Brand} {Model} rumbles smoothly: Hummmmm... luxury style.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
            Console.WriteLine($"Does it have a sunroof: {HasSunroof}.");
            Console.WriteLine($"Does it have a bar: {HaveABar}.");
        }
        public void OpenBar()
        {
            Console.WriteLine("Do you want to see the BarMenu? Yes/No.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "yes")
            {
                Console.WriteLine("🍸 Welcome to the Limousine Bar! Today we have: Champagne, Whiskey, and Mocktails. Cheers!");
            }
            else
            {
                Console.WriteLine($"The bar is empty. SORRY!");
            }
        }
    }
}
