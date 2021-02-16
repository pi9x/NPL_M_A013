using AMSLibrary.Managements;
using System;

namespace AMSConsole
{
    static class ManageFixedwings
    {
        static Managements managements = Managements.InitManagements(FilePath.airportsFile, FilePath.fixedwingsFile, FilePath.helicoptersFile);

        public static void ShowAllFixedwings()
        {
            try
            {
                Console.WriteLine(managements.AllFixedwings());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CreateNewFixedwing()
        {
            string model                = string.Empty;
            string planeType            = string.Empty;
            double cruiseSpeed          = 0;
            double emptyWeight          = 0;
            double maxTakeoffWeight     = 0;
            double minNeededRunwaySize  = 0;

            while (model == string.Empty)
            {
                Console.Write("Model:                    ");
                model = Validation.Model(Console.ReadLine());
            }

            while (planeType == string.Empty)
            {
                Console.Write("Plane type [CAG|LGR|PRV]: ");
                planeType = Validation.PlaneType(Console.ReadLine());
            }

            while (cruiseSpeed == 0)
            {
                Console.Write("Cruise speed:             ");
                cruiseSpeed = Validation.PositiveDouble(Console.ReadLine());
            }

            while (emptyWeight == 0)
            {
                Console.Write("Empty weight:             ");
                emptyWeight = Validation.PositiveDouble(Console.ReadLine());
            }

            while (maxTakeoffWeight == 0)
            {
                Console.Write("Max takeoff weight:       ");
                maxTakeoffWeight = Validation.PositiveDouble(Console.ReadLine());
            }

            while (minNeededRunwaySize == 0)
            {
                Console.Write("Min needed runway size:   ");
                minNeededRunwaySize = Validation.PositiveDouble(Console.ReadLine());
            }

            try
            {
                managements.CreateFixedwing(model, planeType, cruiseSpeed, emptyWeight, maxTakeoffWeight, minNeededRunwaySize);
                Console.WriteLine("Create a new fixedwing successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteFixedwing()
        {
            Console.Write("Fixedwing ID: ");
            string fixedwingId = Validation.Id(Console.ReadLine());

            try
            {
                managements.DeleteFixedwing(fixedwingId);
                Console.WriteLine($"Deleted fixedwing {fixedwingId} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ManageSelectedFixedwing()
        {
            Console.Write("Fixedwing ID: ");
            string fixedwingId = Validation.Id(Console.ReadLine());

            try
            {
                Console.Clear();
                Console.WriteLine(managements.SelectedFixedwing(fixedwingId));
                Console.WriteLine();

                Menu.ShowSelectedFixedwingMenu();
                Console.Write("Choose an action: ");
                string chosen = Console.ReadLine();
                switch (chosen)
                {
                    case "1":
                        ChangeType(fixedwingId);
                        break;

                    case "2":
                        ChangeMinNeededRunwaySize(fixedwingId);
                        break;

                    case "3":
                        Park(fixedwingId);
                        break;

                    case "4":
                        Unpark(fixedwingId);
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

        private static void ChangeMinNeededRunwaySize(string fixedwingId)
        {
            Console.Write("\nCHANGE MIN NEEDED RUNWAY SIZE\nMin needed runway size: ");
            double minNeededRunwaySize = Validation.PositiveDouble(Console.ReadLine());

            try
            {
                managements.ChangeMinNeededRunwaySize(fixedwingId, minNeededRunwaySize);
                Console.WriteLine($"Changed min needed runway size of fixedwing {fixedwingId} to {minNeededRunwaySize}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ChangeType(string fixedwingId)
        {
            Console.Write("\nCHANGE TYPE\nPlane type [CAG|LGR|PRV]: ");
            string type = Validation.PlaneType(Console.ReadLine());

            try
            {
                managements.ChangeType(fixedwingId, type);
                Console.WriteLine($"Changed fixedwing {fixedwingId} type to {type}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Park(string fixedwingId)
        {
            Console.Write("\nPARK TO AN AIRPORT\nAirport ID: ");
            string airportId = Validation.Id(Console.ReadLine());

            try
            {
                managements.ParkFixedwing(airportId, fixedwingId);
                Console.WriteLine($"Parked fixedwing {fixedwingId} to airport {airportId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Unpark(string fixedwingId)
        {
            Console.Write("\nUNPARK\nConfirm airport ID: ");
            string airportId = Validation.Id(Console.ReadLine());

            try
            {
                managements.UnparkFixedwing(airportId, fixedwingId);
                Console.WriteLine($"Unparked fixedwing {fixedwingId} from airport {airportId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
