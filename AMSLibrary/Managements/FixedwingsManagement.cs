using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.Managements
{
    public partial class Managements : IManagements
    {
        private static readonly List<string> fixedwingTypes = new List<string>() { "CAG", "LGR", "PRV" };

        public string AllFixedwings()
        {
            StringBuilder allFixedwings = new StringBuilder("ID          Parking in\n" +
                                                            "--          ----------\n");

            List<Fixedwing> fixedwings = fixedwingsAccess.Get(out _);

            foreach (Fixedwing fixedwing in fixedwings)
                allFixedwings.Append(fixedwing.ShortInfo());

            return allFixedwings.ToString();
        }

        public void CreateFixedwing(string model, string planeType, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight, double minNeededRunwaySize)
        {
            if (model.Length <= 40 && string.IsNullOrWhiteSpace(model))
            {
                if (fixedwingTypes.Contains(planeType))
                    fixedwingsAccess.Create(new Fixedwing(model, planeType, cruiseSpeed, emptyWeight, maxTakeoffWeight, minNeededRunwaySize));
                else
                    throw new Exception("Wrong plane type.");
            }
            else
                throw new Exception("Model must not exceed 40 characters.");
        }

        public void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize)
        {
            Fixedwing fixedwing = fixedwingsAccess.GetById(fixedwingId);
            if (fixedwing.AirportId != string.Empty)
            {
                Airport airport = airportsAccess.GetById(fixedwing.AirportId);
                if (minNeededRunwaySize > airport.RunwaySize)
                    throw new Exception("Min needed runway size exceeds current airport runway size.");
            }
            fixedwingsAccess.ChangeMinNeededRunwaySize(fixedwingId, minNeededRunwaySize);
        }

        public void ChangeType(string fixedwingId, string type)
        {
            if (fixedwingTypes.Contains(type))
                fixedwingsAccess.ChangeType(fixedwingId, type);
            else
                throw new Exception("Wrong plane type.");
        }

        public void DeleteFixedwing(string fixedwingId)
        {
            throw new NotImplementedException();
        }
    }
}
