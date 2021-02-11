using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.DataAccess
{
    class HelicoptersAccess : GenericAccess<Helicopter>, IHelicoptersAccess
    {
        public HelicoptersAccess(string filePath)
        {
            this.filePath = filePath;
        }
    }
}
