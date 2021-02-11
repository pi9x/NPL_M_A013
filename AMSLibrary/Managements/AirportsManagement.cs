using AMSLibrary.DataAccess;
using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.Managements
{
    public class AirportsManagement : IAirportsManagement
    {
        private readonly AirportsAccess airportsAccess;

        #region Create singleton
        private AirportsManagement(string filePath)
        {
            airportsAccess = new AirportsAccess(filePath);
        }

        private static AirportsManagement airportsManagement;

        public static AirportsManagement GetInstance(string filePath)
        {
            if (airportsManagement == null)
                airportsManagement = new AirportsManagement(filePath);

            return airportsManagement;
        }

        #endregion

        public void CreateAirport(string name, double runwaySize, int fixedwingCapacity, int helicopterCapacity)
        {
            // TODO - Validate
            airportsAccess.Create(new Airport(name, runwaySize, fixedwingCapacity, helicopterCapacity));
        }

        //public void AddFixedwing(string airportId, string fixedwingId)
        //{
        //    // TODO - Validate
        //    airportsAccess.AddFixedwing(airportId, fixedwingId);
        //}

        //public void AddHelicopter(string airportId, string helicopterId)
        //{
        //    // TODO - Validate
        //    airportsAccess.AddHelicopter(airportId, helicopterId);
        //}

        //public void DeleteFixedwing(string airportId, string fixedwingId)
        //{
        //    // TODO - Validate
        //    airportsAccess.DeleteFixedwing(airportId, fixedwingId);
        //}

        //public void DeleteHelicopter(string airportId, string helicopterId)
        //{
        //    // TODO - Validate
        //    airportsAccess.DeleteHelicopter(airportId, helicopterId);
        //}
    }
}
