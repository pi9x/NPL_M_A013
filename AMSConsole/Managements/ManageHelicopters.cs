using AMSLibrary.Managements;
using System;

namespace AMSConsole
{
    class ManageHelicopters
    {
        static Managements managements = Managements.InitManagements(FilePath.airportsFile, FilePath.fixedwingsFile, FilePath.helicoptersFile);

        public static void ShowAllHelicopters()
        {
            try
            {
                Console.WriteLine(managements.AllHelicopters());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CreateNewHelicopter()
        {
            string model            = string.Empty;
            double cruiseSpeed      = 0;
            double emptyWeight      = 0;
            double maxTakeoffWeight = 0;
            double range            = 0;

            while (model == string.Empty)
            {
                Console.Write("Model:              ");
                model = Validation.Model(Console.ReadLine());
            }

            while (cruiseSpeed == 0)
            {
                Console.Write("Cruise speed:       ");
                cruiseSpeed = Validation.PositiveDouble(Console.ReadLine());
            }

            while (emptyWeight == 0)
            {
                Console.Write("Empty weight:       ");
                emptyWeight = Validation.PositiveDouble(Console.ReadLine());
            }

            while (maxTakeoffWeight == 0)
            {
                Console.Write("Max takeoff weight: ");
                maxTakeoffWeight = Validation.PositiveDouble(Console.ReadLine());
            }

            while (range == 0)
            {
                Console.Write("Range:              ");
                range = Validation.PositiveDouble(Console.ReadLine());
            }

            try
            {
                managements.CreateHelicopter(model, cruiseSpeed, emptyWeight, maxTakeoffWeight, range);
                Console.WriteLine("Create a new helicopter successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteHelicopter()
        {
            Console.Write("Helicopter ID: ");
            string helicopterId = Validation.Id(Console.ReadLine());

            try
            {
                managements.DeleteHelicopter(helicopterId);
                Console.WriteLine($"Deleted helicopter {helicopterId} successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ManageSelectedHelicopter()
        {
            Console.Write("Helicopter ID: ");
            string helicopterId = Validation.Id(Console.ReadLine());

            try
            {
                Console.Clear();
                Console.WriteLine(managements.SelectedHelicopter(helicopterId));
                Console.WriteLine();

                Menu.ShowSelectedHelicopterMenu();
                Console.Write("Choose an action: ");
                string chosen = Console.ReadLine();
                switch (chosen)
                {

                    case "1":
                        Park(helicopterId);
                        break;

                    case "2":
                        Unpark(helicopterId);
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

        private static void Park(string helicopterId)
        {
            Console.Write("\nPARK TO AN AIRPORT\nAirport ID: ");
            string airportId = Validation.Id(Console.ReadLine());

            try
            {
                managements.ParkHelicopter(airportId, helicopterId);
                Console.WriteLine($"Parked helicopter {helicopterId} to airport {airportId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Unpark(string helicopterId)
        {
            Console.Write("\nUNPARK\nConfirm airport ID: ");
            string airportId = Validation.Id(Console.ReadLine());

            try
            {
                managements.UnparkHelicopter(airportId, helicopterId);
                Console.WriteLine($"Unparked helicopter {helicopterId} from airport {airportId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
