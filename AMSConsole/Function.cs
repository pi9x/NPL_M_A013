using System;

namespace AMSConsole
{
    static class Function
    {
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
                        break;

                    case "2":
                        AMSConsole.ManageAirports.ShowAllAirports();
                        break;

                    case "3":
                        AMSConsole.ManageAirports.SelectAirport();
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
