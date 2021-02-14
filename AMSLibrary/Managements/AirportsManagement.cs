using AMSLibrary.DataAccess;
using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.Managements
{
    public partial class Managements : IManagements
    {
        private readonly int               airportCapacity = 4;
        private readonly AirportsAccess    airportsAccess;
        private readonly FixedwingsAccess  fixedwingsAccess;
        private readonly HelicoptersAccess helicoptersAccess;

        #region Create managements singleton
        private Managements(string airportsPath, string fixedwingsPath, string helicoptersPath)
        {
            airportsAccess = new AirportsAccess(airportsPath);
            fixedwingsAccess = new FixedwingsAccess(fixedwingsPath);
            helicoptersAccess = new HelicoptersAccess(helicoptersPath);
        }

        private static Managements managements;

        public static Managements InitManagements(string airportsPath, string fixedwingsPath, string helicoptersPath)
        {
            if (managements == null)
                managements = new Managements(airportsPath, fixedwingsPath, helicoptersPath);

            return managements;
        }
        #endregion

        public string AllAirports()
        {
            StringBuilder allAirports = new StringBuilder("ID          Name\n" +
                                                          "--          ----\n");
            List<Airport> airports = airportsAccess.Get(out _);

            foreach (Airport airport in airports)
                allAirports.Append(airport.ShortInfo());

            return allAirports.ToString();
        }

        public void CreateAirport(string name, double runwaySize, int fixedwingCapacity, int helicopterCapacity)
        {
            if (airportsAccess.Get(out _).Count < airportCapacity)
                airportsAccess.Create(new Airport(name, runwaySize, fixedwingCapacity, helicopterCapacity));
            else
                throw new Exception($"Exceeds airport capacity ({airportCapacity}).");
        }

        public void DeleteAirport(string airportId)
        {
            airportsAccess.Delete(airportId);
        }

        public string SelectedAirport(string airportId)
        {
            Airport airport = airportsAccess.GetById(airportId);
            return airport.FullInfo();
        }

        public void ParkFixedwing(string airportId, string fixedwingId)
        {
            Airport airport = airportsAccess.GetById(airportId);
            Fixedwing fixedwing = fixedwingsAccess.GetById(fixedwingId);
            if (fixedwing.AirportId == string.Empty)
            {
                if (fixedwing.MinNeededRunwaySize < airport.RunwaySize)
                {
                    airportsAccess.ParkFixedwing(airportId, fixedwingId);
                    fixedwingsAccess.Park(fixedwingId, airportId);
                }
                else
                    throw new Exception("Min needed runway size exceeds airport runway size.");
            }  
            else
                throw new Exception($"Fixedwing {fixedwingId} already parks in airport {fixedwing.AirportId}.");
        }

        public void ParkHelicopter(string airportId, string helicopterId)
        {
            Helicopter helicopter = helicoptersAccess.GetById(helicopterId);
            if (helicopter.AirportId == string.Empty)
                airportsAccess.ParkHelicopter(airportId, helicopterId);
            else
                throw new Exception($"Helicopter {helicopterId} already parks in airport {helicopter.AirportId}.");
        }

        public void UnparkFixedwing(string airportId, string fixedwingId)
        {
            airportsAccess.UnparkFixedwing(airportId, fixedwingId);
            fixedwingsAccess.Unpark(fixedwingId);
        }

        public void UnparkHelicopter(string airportId, string helicopterId)
        {
            airportsAccess.UnparkHelicopter(airportId, helicopterId);
            helicoptersAccess.Unpark(helicopterId);
        }
    }
}
