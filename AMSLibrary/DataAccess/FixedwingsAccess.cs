using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.DataAccess
{
    class FixedwingsAccess : GenericAccess<Fixedwing>, IFixedwingsAccess
    {
        public FixedwingsAccess(string filePath)
        {
            this.filePath = filePath;
        }
    }
}
