using System;

namespace AMSConsole
{
    class Menu
    {
        public static void ShowMainMenu()
        {
            Console.Write("AIRPORT MANAGEMENT SYSTEM - HOME\n\n" +
                          "[1] - Manage airports\n" +
                          "[2] - Manage fixedwings\n" +
                          "[3] - Manage helicopters\n" +
                          "[0] - Exit\n\n");
        }

        public static void ShowAirportMenu()
        {
            Console.Write("MANAGE AIRPORTS\n\n" +
                          "[1] - Create a new airport\n" +
                          "[2] - Select an airport\n" +
                          "[3] - Delete an airport\n" +
                          "[0] - Back to home\n\n");
        }

        public static void ShowSelectedAirportMenu()
        {
            Console.Write("MANAGE THIS AIRPORT\n\n" +
                          "[1] - Park a fixedwing\n" +
                          "[2] - Unpark a fixedwing\n" +
                          "[3] - Park a helicopter\n" +
                          "[4] - Unpark a helicopter\n" +
                          "[0] - Back to airports management\n\n");
        }

        public static void ShowFixedwingMenu()
        {
            Console.Write("MANAGE FIXEDWINGS\n\n" +
                          "[1] - Create a new fixedwing\n" +
                          "[2] - Select a fixedwing\n" +
                          "[3] - Delete a fixedwing\n" +
                          "[0] - Back to home\n\n");
        }

        public static void ShowSelectedFixedwingMenu()
        {
            Console.Write("MANAGE THIS FIXEDWING\n\n" +
                          "[1] - Change plane type\n" +
                          "[2] - Change min needed runway size\n" +
                          "[3] - Park to an airport\n" +
                          "[4] - Unpark\n" +
                          "[0] - Back to fixedwings management\n\n");
        }

        public static void ShowHelicopterMenu()
        {
            Console.Write("MANAGE HELICOPTERS\n\n" +
                          "[1] - Create a new helicopter\n" +
                          "[2] - Select a helicopter\n" +
                          "[3] - Delete a helicopter\n" +
                          "[0] - Back to main menu\n\n");
        }

        public static void ShowSelectedHelicopterMenu()
        {
            Console.Write("MANAGE THIS HELICOPTER\n\n" +
                          "[1] - Park to an airport\n" +
                          "[2] - Unpark\n" +
                          "[0] - Back to helicopters management\n\n");
        }
    }
}
