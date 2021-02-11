using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.DataAccess
{
    interface IAirportsAccess : IGenericAccess<Airport>
    {
        void AddFixedwing(string airportId, string fixedwingId);
        void DeleteFixedwing(string airportId, string fixedwingId);
        void AddHelicopter(string airportId, string helicopterId);
        void DeleteHelicopter(string airportId, string helicopterId);
    }
}
