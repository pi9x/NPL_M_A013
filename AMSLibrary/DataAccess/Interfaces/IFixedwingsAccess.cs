using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.DataAccess
{
    interface IFixedwingsAccess : IGenericAccess<Fixedwing>
    {
        void Park(string airportId);
        void Unpark();
        void ChangeType(string type);
        void
    }
}
