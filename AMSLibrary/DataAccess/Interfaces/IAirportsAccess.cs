using AMSLibrary.Entities;

namespace AMSLibrary.DataAccess
{
    interface IAirportsAccess : IGenericAccess<Airport>
    {
        void ParkFixedwing(string airportId, string fixedwingId);
        void UnparkFixedwing(string airportId, string fixedwingId);
        void ParkHelicopter(string airportId, string helicopterId);
        void UnparkHelicopter(string airportId, string helicopterId);
    }
}
