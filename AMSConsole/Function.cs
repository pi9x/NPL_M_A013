using System;

namespace AMSConsole
{
    static class Function
    {
        public static void MainManagement()
        {
            Menu.ShowMainMenu();
            string chosen = Console.ReadLine();

            while (chosen != "0")
            {
                switch (chosen)
                {
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
            Menu.ShowAirportMenu();
            string chosen = Console.ReadLine();

            while (chosen != "0")
            {
                switch (chosen)
                {
                    case "1":
                        AMSConsole.ManageAirports.CreateNewAirport();

                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        //ManageAirports();
                        chosen = "0";
                        break;

                    case "2":
                        AMSConsole.ManageAirports.ShowAllAirports();
                        
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        //ManageAirports();
                        break;

                    case "3":
                        AMSConsole.ManageAirports.ManageSelectedAirport();

                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        //ManageAirports();
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
