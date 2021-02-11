using AMSLibrary.Entities;

namespace AMSLibrary.DataAccess
{
    class AirportsAccess : GenericAccess<Airport>, IAirportsAccess
    {
        public AirportsAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public void ParkFixedwing(string airportId, string fixedwingId)
        {
            Airport airport = GetById(airportId);
            airport.ParkFixedwing(fixedwingId);
            Update(airport);
        }

        public void ParkHelicopter(string airportId, string helicopterId)
        {
            Airport airport = GetById(airportId);
            airport.ParkHelicopter(helicopterId);
            Update(airport);
        }

        public void UnparkFixedwing(string airportId, string fixedwingId)
        {
            Airport airport = GetById(airportId);
            airport.UnparkFixedwing(fixedwingId);
            Update(airport);
        }

        public void UnparkHelicopter(string airportId, string helicopterId)
        {
            Airport airport = GetById(airportId);
            airport.UnparkHelicopter(helicopterId);
            Update(airport);
        }
    }
}
