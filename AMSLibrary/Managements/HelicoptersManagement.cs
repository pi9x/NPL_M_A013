using AMSLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.Managements
{
    public partial class Managements : IManagements
    {
        public string AllHelicopters()
        {
            StringBuilder allHelicopters = new StringBuilder("ID          Parking in    Model\n" +
                                                             "--          ----------    -----\n");

            List<Helicopter> helicopters = helicoptersAccess.Get(out _);

            foreach (Helicopter helicopter in helicopters)
                allHelicopters.Append(helicopter.ShortInfo());

            return allHelicopters.ToString();
        }

        public void CreateHelicopter(string model, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight, double range)
        {
            if (emptyWeight * 1.5 >= maxTakeoffWeight)
                helicoptersAccess.Create(new Helicopter(model, cruiseSpeed, emptyWeight, maxTakeoffWeight, range));
            else
                throw new Exception("Max takeoff weight must not exceed 1.5 times of its empty weight.");
        }

        public void DeleteHelicopter(string helicopterId)
        {
            helicoptersAccess.Delete(helicopterId);
        }

        public string SelectedHelicopter(string helicopterId)
        {
            Helicopter helicopter = helicoptersAccess.GetById(helicopterId);
            return helicopter.FullInfo();
        }
    }
}
