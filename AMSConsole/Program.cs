using System;
using AMSLibrary.Managements;

namespace AMSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ShowMainMenu();
            string chosen = Console.ReadLine();

            while (chosen != "0")
            {
                switch (chosen)
                {
                    case "1":
                        Function.ManageAirports();
                        break;

                    case "2":
                        Function.ManageFixedwings();
                        break;

                    case "3":
                        Function.ManageHelicopters();
                        break;

                    default:
                        Console.Write("Wrong action!\nChoose an action: ");
                        chosen = Console.ReadLine();
                        break;
                }
            }

        }
    }
}
