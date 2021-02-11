using AMSLibrary.DataAccess;
using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMSLibrary.Managements
{
    class FixedwingsManagement : IFixedwingsManagement
    {
        private readonly List<string> fixedwingTypes = new List<string>() { "CAG", "LGR", "PRV" };

        private readonly FixedwingsAccess fixedwingsAccess;

        #region Create singleton
        private FixedwingsManagement(string filePath)
        {
            fixedwingsAccess = new FixedwingsAccess(filePath);
        }

        private static FixedwingsManagement fixedwingsManagement;

        public static FixedwingsManagement GetInstance(string filePath)
        {
            if (fixedwingsManagement == null)
                fixedwingsManagement = new FixedwingsManagement(filePath);

            return fixedwingsManagement;
        }
        #endregion

        public void CreateFixedwing(string model, string planeType, double cruiseSpeed, double emptyWeight,
                            double maxTakeoffWeight, double minNeededRunwaySize)
        {
            if (model.Length <= 40 && fixedwingTypes.Contains(planeType))
                fixedwingsAccess.Create(new Fixedwing(model, planeType, cruiseSpeed, emptyWeight, maxTakeoffWeight, minNeededRunwaySize));
            else
                throw new Exception("Error creating fixedwing.");
        }

        public void ChangeType(string fixedwingId, string type)
        {
            if (fixedwingTypes.Contains(type))
            {
                Fixedwing fixedwing = fixedwingsAccess.GetById(fixedwingId);
                fixedwing.PlaneType = type;
                fixedwingsAccess.Update(fixedwing);
            }
            else
                throw new Exception("Wrong fixedwing type.");
        }

        public void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize)
        {
            Fixedwing fixedwing = fixedwingsAccess.GetById(fixedwingId);
            //Airport airport = 
            fixedwing.MinNeededRunwaySize = minNeededRunwaySize;
            fixedwingsAccess.Update(fixedwing);
        }
    }
}
