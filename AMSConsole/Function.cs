using System;

namespace AMSConsole
{
    static class Function
    {
        public static void MainManagement()
        {
            string chosen = string.Empty;

            while (chosen != "0")
            {
                Console.Clear();
                Menu.ShowMainMenu();
                Console.Write("Choose an action: ");
                chosen = Console.ReadLine();

                switch (chosen)
                {
                    case "0":
                        break;

                    case "1":
                        ManageAirports();
                        break;

                    case "2":
                        ManageFixedwings();
                        break;

                    case "3":
                        ManageHelicopters();
                        break;

                    default:
                        Console.Write("Wrong action!\nChoose an action: ");
                        chosen = Console.ReadLine();
                        break;
                }
            }
        }

        public static void ManageAirports()
        {
            string chosen = string.Empty;

            while (chosen != "0")
            {
                Console.Clear();
                Console.Write("ALL EXISTING AIRPORTS\n\n");
                AMSConsole.ManageAirports.ShowAllAirports();
                Console.WriteLine();

                Menu.ShowAirportMenu();
                Console.Write("Choose an action: ");
                chosen = Console.ReadLine();

                switch (chosen)
                {
                    case "0":
                        break;

                    case "1":
                        Console.Clear();
                        Console.Write("ALL EXISTING AIRPORTS\n\n");
                        AMSConsole.ManageAirports.ShowAllAirports();
                        Console.WriteLine();

                        Console.Write("CREATE A NEW AIRPORT\n\n");
                        AMSConsole.ManageAirports.CreateNewAirport();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("ALL EXISTING AIRPORTS\n\n");
                        AMSConsole.ManageAirports.ShowAllAirports();
                        Console.WriteLine();

                        Console.Write("SELECT AN AIRPORT\n\n");
                        AMSConsole.ManageAirports.ManageSelectedAirport();

                        break;

                    default:
                        Console.Write("Wrong action!\nChoose an action: ");
                        chosen = Console.ReadLine();
                        break;
                }
            }
        }

        public static void ManageFixedwings()
        {
            Menu.ShowFixedwingMenu();

        }

        public static void ManageHelicopters()
        {
            Menu.ShowHelicopterMenu();

        }
    }
}
