using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.DataAccess
{
    class AirportsAccess : GenericAccess<Airport>, IAirportsAccess
    {
        public AirportsAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public void AddFixedwing(string airportId, string fixedwingId)
        {
            Airport airport = GetById(airportId);

            if (airport.FixedwingIds == null)
                airport.FixedwingIds = new List<string>();

            airport.FixedwingIds.Add(fixedwingId);

            Update(airport);
        }

        public void AddHelicopter(string airportId, string helicopterId)
        {
            Airport airport = GetById(airportId);

            if (airport.HelicopterIds == null)
                airport.HelicopterIds = new List<string>();

            airport.HelicopterIds.Add(helicopterId);

            Update(airport);
        }

        public void DeleteFixedwing(string airportId, string fixedwingId)
        {
            Airport airport = GetById(airportId);

            if (!airport.FixedwingIds.Contains(fixedwingId))
                throw new Exception($"Fixedwing {fixedwingId} is not in airport {airportId}.");

            airport.FixedwingIds.Remove(fixedwingId);

            Update(airport);
        }

        public void DeleteHelicopter(string airportId, string helicopterId)
        {
            Airport airport = GetById(airportId);

            if (!airport.HelicopterIds.Contains(helicopterId))
                throw new Exception($"Helicopter {helicopterId} is not in airport {airportId}.");

            airport.HelicopterIds.Remove(helicopterId);

            Update(airport);
        }
    }
}
