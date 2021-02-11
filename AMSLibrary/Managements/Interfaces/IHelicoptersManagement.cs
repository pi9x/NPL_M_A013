using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.Managements
{
    interface IHelicoptersManagement
    {
        void CreateHelicopter(string model, double cruiseSpeed, double emptyWeight,
                              double maxTakeoffWeight, double range);
    }
}
