using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.Managements
{
    interface IFixedwingsManagement
    {
        void CreateFixedwing(string model, string planeType, double cruiseSpeed, double emptyWeight,
                             double maxTakeoffWeight, double minNeededRunwaySize);
        void ChangeType(string fixedwingId, string type);
        void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize);
    }
}
