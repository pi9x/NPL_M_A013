using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.Managements
{
    interface IAirportsManagement
    {
        void CreateAirport(string name, double runwaySize, int fixedwingCapacity, int helicopterCapacity);
        void AddFixedwing(string airportId, string fixedwingId);
        void AddHelicopter(string airportId, string helicopterId);
        void DeleteFixedwing(string airportId, string fixedwingId);
        void DeleteHelicopter(string airportId, string helicopterId);
    }
}
