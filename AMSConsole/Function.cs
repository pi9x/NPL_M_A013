﻿using System;

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

        private static void ManageAirports()
        {
            string chosen = string.Empty;

            while (chosen != "0")
            {
                ShowAllExistingAirports();
                Menu.ShowAirportMenu();
                Console.Write("Choose an action: ");
                chosen = Console.ReadLine();

                switch (chosen)
                {
                    case "0":
                        break;

                    case "1":
                        ShowAllExistingAirports();
                        Console.Write("CREATE A NEW AIRPORT\n\n");
                        AMSConsole.ManageAirports.CreateNewAirport();
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        break;

                    case "2":
                        ShowAllExistingAirports();
                        Console.Write("SELECT AN AIRPORT\n\n");
                        AMSConsole.ManageAirports.ManageSelectedAirport();
                        break;

                    case "3":
                        ShowAllExistingAirports();
                        Console.Write("DELETE AN AIRPORT\n\n");
                        AMSConsole.ManageAirports.DeleteAirport();
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("Wrong action!\nChoose an action: ");
                        chosen = Console.ReadLine();
                        break;
                }
            }
        }

        private static void ShowAllExistingAirports()
        {
            Console.Clear();
            Console.Write("ALL EXISTING AIRPORTS\n\n");
            AMSConsole.ManageAirports.ShowAllAirports();
            Console.WriteLine();
        }

        private static void ManageFixedwings()
        {
            string chosen = string.Empty;

            while (chosen != "0")
            {
                ShowAllExistingFixedwings();
                Menu.ShowFixedwingMenu();
                Console.Write("Choose an action: ");
                chosen = Console.ReadLine();

                switch (chosen)
                {
                    case "1":
                        ShowAllExistingFixedwings();
                        Console.Write("CREATE A NEW FIXEDWING\n\n");
                        AMSConsole.ManageFixedwings.CreateNewFixedwing();
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        break;

                    case "2":
                        ShowAllExistingFixedwings();
                        Console.Write("SELECT A FIXEDWING\n\n");
                        AMSConsole.ManageFixedwings.ManageSelectedFixedwing();
                        break;

                    case "3":
                        ShowAllExistingFixedwings();
                        Console.Write("DELETE A FIXEDWING\n\n");
                        AMSConsole.ManageFixedwings.DeleteFixedwing();
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        break;

                    case "0":
                        break;

                    default:
                        Console.Write("Wrong action!\nChoose an action: ");
                        chosen = Console.ReadLine();
                        break;
                }
            }

        }

        private static void ShowAllExistingFixedwings()
        {
            Console.Clear();
            Console.Write("ALL EXISTING FIXEDWINGS\n\n");
            AMSConsole.ManageFixedwings.ShowAllFixedwings();
            Console.WriteLine();
        }

        private static void ManageHelicopters()
        {
            string chosen = string.Empty;

            while (chosen != "0")
            {
                ShowAllExistingHelicopters();
                Menu.ShowHelicopterMenu();
                Console.Write("Choose an action: ");
                chosen = Console.ReadLine();

                switch (chosen)
                {
                    case "1":
                        ShowAllExistingHelicopters();
                        Console.Write("CREATE A NEW HELICOPTER\n\n");
                        AMSConsole.ManageHelicopters.CreateNewHelicopter();
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        break;

                    case "2":
                        ShowAllExistingHelicopters();
                        Console.Write("SELECT A HELICOPTER\n\n");
                        AMSConsole.ManageHelicopters.ManageSelectedHelicopter();
                        break;

                    case "3":
                        ShowAllExistingHelicopters();
                        Console.Write("DELETE A HELICOPTER\n\n");
                        AMSConsole.ManageHelicopters.DeleteHelicopter();
                        Console.Write("Press any key to go back...");
                        Console.ReadKey();
                        break;

                    case "0":
                        break;

                    default:
                        Console.Write("Wrong action!\nChoose an action: ");
                        chosen = Console.ReadLine();
                        break;
                }
            }
        }

        private static void ShowAllExistingHelicopters()
        {
            Console.Clear();
            Console.Write("ALL EXISTING HELICOPTERS\n\n");
            AMSConsole.ManageHelicopters.ShowAllHelicopters();
            Console.WriteLine();
        }
    }
}
