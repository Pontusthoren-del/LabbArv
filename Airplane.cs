using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbArv
{
    internal class Airplane : Vehicle
    {
        public int WingSpan { get; set; }
        public int MaxAltitude { get; set; }
        public int EmergencyDoors { get; set; }

        public Airplane(string brand, string model, int maxspeed, int doors, bool gasoline, int wingspan, int altitude, int emergencydoors) : base(brand, model, maxspeed, doors, gasoline)
        {
            WingSpan = wingspan;
            MaxAltitude = altitude;
            EmergencyDoors = emergencydoors;
        }
        public Airplane() : base()
        {
            Brand = "Airbus";
            Model = "A320";
            Doors = 4;
            EmergencyDoors = 4;
            Gasoline = false;
            WingSpan = 36;
            MaxAltitude = 12000;
            MaxSpeed = 871;
        }
        public override void StartEngine()
        {
            Console.WriteLine("WheeeeeeeEEEEEEERRRRRROOOOOOOOMMM!!!");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("====== Information of the Vehichle ======");
            Console.WriteLine($"Brand : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Maxspeed : {MaxSpeed}km/h.");
            Console.WriteLine($"Amount of doors : {Doors}");
            Console.WriteLine($"Amount of Emergency doors: {EmergencyDoors + Doors}.");
            Console.WriteLine($"Does it use gasoline : {Gasoline}.");
            Console.WriteLine($"Wingspan: {WingSpan}");
            Console.WriteLine($"Maxaltitude: {MaxAltitude}");
        }
        public bool PassControl()
        {
            Console.WriteLine("======PASSCONTROL======");
            Console.WriteLine("Do you have your passport?.Yes/No");
            while (true)
            {

                string input = Console.ReadLine().ToLower().Trim();

                if (input == "yes")
                {
                    Console.WriteLine("Welcome onboard!");
                    return true;
                }
                else if(input=="no")
                {
                    Console.WriteLine("Sorry.. Go back home and get it...");
                    Console.ReadKey();
                    return false;
                }
                else
                {
                    Console.WriteLine("Ehum...I asked YES OR NO???");
                }
            }
        }
    }
}
