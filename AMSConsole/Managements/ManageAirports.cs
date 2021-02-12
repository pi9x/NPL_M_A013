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
            bool success = false;

            while (!success)
            {
                string name = string.Empty;
                double runwaySize = 0;
                int fixedwingCapacity = 0;
                int helicopterCapacity = 0;

                while (string.IsNullOrWhiteSpace(name))
                {
                    Console.Write("Airport name:        ");
                    name = Console.ReadLine().Trim().ToUpper();
                }

                while (runwaySize == 0)
                {
                    Console.Write("Runway size:         ");
                    runwaySize = Validation.PositiveDouble(Console.ReadLine());
                }

                while (fixedwingCapacity == 0)
                {
                    Console.Write("Fixedwing capacity:  ");
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
                    Console.WriteLine("Create new airport successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n" + e.Message);
                    Console.Write("Press any key to create a new airport again...");
                    Console.ReadKey();
                }
            }
        }

        public static void ShowAllAirports()
        {
            try
            {
                Console.WriteLine(managements.AllAirports());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ManageSelectedAirport()
        {
            Console.Write("Airport ID: ");
            string airportId = Console.ReadLine().Trim().ToUpper();

            try
            {
                Console.Clear();
                Console.WriteLine(managements.SelectedAirport(airportId));

                Console.WriteLine();
                Menu.ShowSelectedAirportMenu();
                Console.Write("Choose an action: ");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Press any key to go back...");
                Console.ReadKey();
            }


        }

        public static void ParkFixedwing()
        {
            
        }

        public static void UnparkFixedwing()
        {

        }

        public static void ParkHelicopter()
        {

        }

        public static void UnparkHelicopter()
        {

        }
    }
}
