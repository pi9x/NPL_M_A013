using AMSLibrary.Managements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSConsole
{
    static class ManageAirports
    {
        static Managements managements = Managements.InitManagements(FilePath.airportsFile, FilePath.fixedwingsFile, FilePath.helicoptersFile);

        public static void CreateNewAirport()
        {
            string name = string.Empty;
            double runwaySize = 0;
            int fixedwingCapacity = 0;
            int helicopterCapacity = 0;

            bool success = false;

            while (!success)
            {
                Console.Clear();
                Console.WriteLine("ADD A NEW AIRPORT\n");

                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.Write("Airport name: ");
                    name = Console.ReadLine().Trim().ToUpper();
                }

                while (runwaySize == 0)
                {
                    Console.Write("Runway size: ");
                    runwaySize = Validation.PositiveDouble(Console.ReadLine());
                }

                while (fixedwingCapacity == 0)
                {
                    Console.Write("Fixedwing capacity: ");
                    fixedwingCapacity = Validation.PositiveInteger(Console.ReadLine());
                }

                while (helicopterCapacity == 0)
                {
                    Console.Write("Helicopter capacity: ");
                    helicopterCapacity = Validation.PositiveInteger(Console.ReadLine());
                }

                try
                {
                    managements.CreateAirport(name, runwaySize, fixedwingCapacity, helicopterCapacity);
                    success = true;
                    Console.Write("Press any key to go back to main menu...");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Write("Press any key to create a new airport again...");
                    Console.ReadKey();
                }
            }
        }

        public static void ShowAllAirports()
        {
            Console.Clear();
            Console.WriteLine("ALL AIRPORTS\n");

        }

        public static void SelectAirport()
        {

        }
    }
}
