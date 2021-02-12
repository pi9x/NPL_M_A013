using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSConsole
{
    class Menu
    {
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.Write("NHD AIRPORT MANAGEMENT SYSTEM\n\n" +
                          "[1] - Manage airports\n" +
                          "[2] - Manage fixedwings\n" +
                          "[3] - Manage helicopters\n" +
                          "[0] - Exit\n\n" +
                          "Choose an action: ");
        }

        public static void ShowAirportMenu()
        {
            Console.Clear();
            Console.Write("MANAGE AIRPORTS\n\n" +
                          "[1] - Create a new airport\n" +
                          "[2] - Show all existing airports\n" +
                          "[3] - Show an airport information\n" +
                          "[0] - Back to main menu\n\n" +
                          "Choose an action: ");
        }

        public static void ShowSelectedAirportMenu()
        {
            Console.Write("[1] - Park a fixedwing\n" +
                          "[2] - Unpark a fixedwing\n" +
                          "[3] - Park a helicopter\n" +
                          "[4] - Unpark a helicopter\n" +
                          "[5] - Back to airports management\n\n" +
                          "Choose an action: ");
        }

        public static void ShowFixedwingMenu()
        {
            Console.Clear();
            Console.Write("MANAGE FIXEDWINGS\n\n" +
                          "[1] - Create a new fixedwing\n" +
                          "[2] - Show all existing fixedwings with parking airports\n" +
                          "[3] - Show a fixedwing information\n" +
                          "[0] - Back to main menu\n\n" +
                          "Choose an action: ");
        }

        public static void ShowDetailedFixedwingMenu()
        {
            Console.Write("[1] - Change plane type\n" +
                          "[2] - Change min needed runway size\n" +
                          "[0] - Back to fixedwings management\n\n" +
                          "Choose an action: ");
        }

        public static void ShowHelicopterMenu()
        {
            Console.Clear();
            Console.Write("MANAGE FIXEDWINGS\n\n" +
                          "[1] - Create a new helicopter\n" +
                          "[2] - Show all existing helicopter with parking airports\n" +
                          "[3] - Show a helicopter information\n" +
                          "[0] - Back to main menu\n\n" +
                          "Choose an action: ");
        }
    }
}
