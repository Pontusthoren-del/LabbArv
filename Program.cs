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
                            MyMotorcycle();
                            break;
                        case 3:
                            MyTruck();
                            break;
                        case 4:
                            MyAirplane();
                            break;
                        case 5:
                            CreateCustomVehicle();
                            break;
                        case 6:
                            ShutOff();
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
            Console.WriteLine("Welcome to our vehicle service!");
            Console.WriteLine("You can now choose from the following options:");
            Console.WriteLine("You will get to listen to and see information about the different vehicles.");
            Console.WriteLine("1) Car.");
            Console.WriteLine("2) Motorcycle.");
            Console.WriteLine("3) Truck.");
            Console.WriteLine("4) Airplane.");
            Console.WriteLine("5) Create custom vehicle.");
            Console.WriteLine("6) End program.");
        }
        public static void CreateCustomVehicle()
        {
            Console.WriteLine("You want to create a custom vehicle.");
            Console.WriteLine("\tChoose below.");
            Console.WriteLine("1) Car.");
            Console.WriteLine("2) Motorcycle.");
            Console.WriteLine("3) Truck.");
            Console.WriteLine("4) Return to mainmenu.");
            string input = Console.ReadLine();
            int choice;
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:

                        CreateCustomCar();
                        break;
                    case 2:
                        CreateCustomMotorcycle();
                        break;
                    case 3:
                        CreateCustomTruck();
                        break;
                    case 4:
                        RunMainMenu();
                        break;
                }
            }
        }
        public static void CreateCustomCar()
        {
            Console.Clear();
            Console.WriteLine("Create a new custom Car with own attributes.");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("MaxSpeed (km/h): ");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.Write("Doors: ");
            int doors = int.Parse(Console.ReadLine());
            Console.Write("Gasoline(true/false): ");
            bool gasoline;
            while (!bool.TryParse(Console.ReadLine(), out gasoline))
            {
                Console.WriteLine("Ogiltlig input! Skriv \"true\" eller \"false\".");
                Console.Write("Gasoline: (true/false) ");
            }
            Console.Write("Has Sunroof(true/false): ");
            bool sunroof;
            while (!bool.TryParse(Console.ReadLine(), out sunroof))
            {
                Console.WriteLine("Ogiltlig input! Skriv \"true\" eller \"false\".");
                Console.Write("Has sidecar: (true/false): ");
            }

            Car customCar = new Car(brand, model, maxSpeed, doors, gasoline, sunroof);
            customCar.StartVehicle();
            customCar.StartEngine();
            customCar.StopVehicle();
            customCar.DisplayInfo();

            Console.WriteLine("Press Enter to return.");
            Console.ReadLine();
            RunMainMenu();
        }
        public static void CreateCustomMotorcycle()
        {
            Console.Clear();
            Console.WriteLine("Create a new custom Motorcycle with own attributes.");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("MaxSpeed (km/h): ");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.Write("Gasoline: (true/false) ");
            bool gasoline;
            while (!bool.TryParse(Console.ReadLine(), out gasoline))
            {
                Console.WriteLine("Ogiltlig input! Skriv \"true\" eller \"false\".");
                Console.Write("Gasoline: (true/false) ");
            }
            Console.Write("Has sidecar: (true/false) ");
            bool sidecar;
            while (!bool.TryParse(Console.ReadLine(), out sidecar))
            {
                Console.WriteLine("Ogiltlig input! Skriv \"true\" eller \"false\".");
                Console.Write("Has sidecar: (true/false): ");
            }

            Motorcycle customMotorcycle = new Motorcycle(brand, model, maxSpeed, gasoline, sidecar);
            customMotorcycle.StartVehicle();
            customMotorcycle.StartEngine();
            customMotorcycle.StopVehicle();
            customMotorcycle.DisplayInfo();

            Console.WriteLine("Press Enter to return.");
            Console.ReadLine();
            RunMainMenu();
        }
        public static void CreateCustomTruck()
        {
            Console.Clear();
            Console.WriteLine("Create a new custom Truck with own attributes.");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("MaxSpeed (km/h): ");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.Write("Doors: ");
            int doors = int.Parse(Console.ReadLine());
            Console.Write("Gasoline(true/false): ");
            bool gasoline;
            while (!bool.TryParse(Console.ReadLine(), out gasoline))
            {
                Console.WriteLine("Ogiltlig input! Skriv \"true\" eller \"false\".");
                Console.Write("Gasoline(true/false): ");
            }
            Console.Write("Load Capacity: ");
            int loadCapacity = int.Parse(Console.ReadLine());

            Truck customTruck = new Truck(brand, model, maxSpeed, doors, gasoline, loadCapacity);
            customTruck.StartVehicle();
            customTruck.StartEngine();
            customTruck.StopVehicle();
            customTruck.DisplayInfo();

            Console.WriteLine("Press Enter to return.");
            Console.ReadLine();
            RunMainMenu();
        }
        public static void MyTruck()
        {
            Truck myTruck = new Truck();
            myTruck.StartVehicle();
            myTruck.StartEngine();
            myTruck.Unload();
            myTruck.StopVehicle();
            myTruck.DisplayInfo();
            Console.WriteLine("Tryck Enter för att återkomma till menyn");
            Console.ReadLine();
            RunMainMenu();
        }
        public static void MyCar()
        {
            Console.WriteLine("You chose Car! Which type would you like?");
            Console.WriteLine("1) \"Normal\"Car");
            Console.WriteLine("2) Limousin");
            Console.WriteLine("3) Armored Vehicle");
            Console.WriteLine("4) Return to main menu");
            string input = Console.ReadLine();
            int choice;
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Car myCar = new Car();
                        myCar.StartVehicle();
                        myCar.StartEngine();
                        myCar.StopVehicle();
                        myCar.DisplayInfo();
                        Console.WriteLine("Tryck Enter för att återkomma till menyn");
                        Console.ReadLine();
                        RunMainMenu();
                        break;
                    case 2:
                        Limousin myLimousin = new Limousin();
                        myLimousin.StartVehicle();
                        myLimousin.StartEngine();
                        myLimousin.OpenBar();
                        myLimousin.StopVehicle();
                        myLimousin.DisplayInfo();
                        Console.WriteLine("Tryck Enter för att återkomma till menyn");
                        Console.ReadLine();
                        RunMainMenu();
                        break;
                    case 3:
                        ArmoredVehicle myArmoredVehicle = new ArmoredVehicle();
                        myArmoredVehicle.StartVehicle();
                        myArmoredVehicle.StartEngine();
                        myArmoredVehicle.ShotTurret();
                        myArmoredVehicle.StopVehicle();
                        myArmoredVehicle.DisplayInfo();
                        Console.WriteLine("Tryck Enter för att återkomma till menyn");
                        Console.ReadLine();
                        RunMainMenu();
                        break;
                }
            }
        }
        public static void MyMotorcycle()
        {
            Motorcycle myMotorcycle = new Motorcycle();
            myMotorcycle.StartVehicle();
            myMotorcycle.StartEngine();
            myMotorcycle.StopVehicle();
            myMotorcycle.DisplayInfo();
            Console.WriteLine("Tryck Enter för att återkomma till menyn");
            Console.ReadLine();
            RunMainMenu();
        }
        public static void MyAirplane()
        {
            Airplane myAirplane = new Airplane();
            if (myAirplane.PassControl())
            {
            myAirplane.StartVehicle();
            myAirplane.StartEngine();
            myAirplane.StopVehicle();
            myAirplane.DisplayInfo();
            Console.WriteLine("Tryck Enter för att återkomma till menyn");
            Console.ReadLine();
            }
            RunMainMenu();
        }
        public static void ShutOff()
        {
            Environment.Exit(0);
        }
    }
}
