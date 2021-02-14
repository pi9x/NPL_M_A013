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

        public static void CreateNewAirport()
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
                Console.WriteLine("Create new airport successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteAirport()
        {
            Console.Write("Airport ID: ");
            string airportId = Console.ReadLine().Trim().ToUpper();

            try
            {
                managements.DeleteAirport(airportId);
                Console.WriteLine($"Deleted airport {airportId} successfully.");
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
                string chosen = Console.ReadLine();

                switch (chosen)
                {
                    case "1":
                        ParkFixedwing(airportId);
                        break;

                    case "2":
                        UnparkFixedwing(airportId);
                        break;

                    case "3":
                        ParkHelicopter(airportId);
                        break;

                    case "4":
                        UnparkHelicopter(airportId);
                        break;

                    case "0":
                        break;

                    default:
                        Console.Write("Wrong option!\nI'm too tired to write a loop here, so press any key to go back...");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ParkFixedwing(string airportId)
        {
            Console.Write("\nPARK A FIXEDWING\nFixedwing ID: ");
            string fixedwingId = Console.ReadLine().Trim().ToUpper();
            try
            {
                managements.ParkFixedwing(airportId, fixedwingId);
                Console.WriteLine($"Parked fixedwing {fixedwingId} to airport {airportId} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void UnparkFixedwing(string airportId)
        {
            Console.Write("\nUNPARK A FIXEDWING\nFixedwing ID: ");
            string fixedwingId = Console.ReadLine().Trim().ToUpper();
            try
            {
                managements.UnparkFixedwing(airportId, fixedwingId);
                Console.WriteLine($"Unparked fixedwing {fixedwingId} from airport {airportId} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ParkHelicopter(string airportId)
        {
            Console.Write("\nPARK A HELICOPTER\nHelicopter ID: ");
            string helicopterId = Console.ReadLine().Trim().ToUpper();
            try
            {
                managements.ParkHelicopter(airportId, helicopterId);
                Console.WriteLine($"Parked helicopter {helicopterId} to airport {airportId} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void UnparkHelicopter(string airportId)
        {
            Console.Write("\nUNPARK A HELICOPTER\nHelicopter ID: ");
            string helicopterId = Console.ReadLine().Trim().ToUpper();
            try
            {
                managements.UnparkHelicopter(airportId, helicopterId);
                Console.WriteLine($"Unparked helicopter {helicopterId} from airport {airportId} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
