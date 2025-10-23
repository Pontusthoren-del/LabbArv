namespace LabbArv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }
        public static void StartProgram()
        {
            RunMainMenu();
            bool loggedin = true;
            while (loggedin)
            {

                string input = Console.ReadLine();
                int choice;
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            MyCar();
                            break;
                        case 2:
                            ShutOff();
                            break;
                        case 3:
                            //Buss
                            break;
                        default:
                            break;
                    }
                }
            }

        }
        public static void RunMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till våran fordonstjänst!");
            Console.WriteLine("Du får nu välja mellan några alternativ nu.");
            Console.WriteLine("Du kommer få lyssna och se info om de olika fordonen");
            Console.WriteLine("1) Bil.");
            Console.WriteLine("2) Avsluta.");
        }
        public static void ShutOff()
        {
            Environment.Exit(0);
        }
        public static void MyCar()
        {
            Vehicle myCar = new Vehicle("Seat", "Leon", 180, 4, true);
            myCar.StartVehicle();
            myCar.startEngine();
            myCar.StopVehicle();
            myCar.DisplayInfo();
            Console.WriteLine("Tryck Enter för att återkomma till menyn");
            Console.ReadLine();
            
            RunMainMenu();

        }

    }
}
