using AMSLibrary.Entities;
using System;

namespace AMSLibrary.Managements
{
    public partial class Managements : IManagements
    {
        public string AllHelicopters()
        {
            throw new NotImplementedException();
        }

        public void CreateHelicopter(string model, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight, double range)
        {
            if (model.Length <= 40 && string.IsNullOrWhiteSpace(model))
            {
                if (emptyWeight * 1.5 >= maxTakeoffWeight)
                    helicoptersAccess.Create(new Helicopter(model, cruiseSpeed, emptyWeight, maxTakeoffWeight, range));
                else
                    throw new Exception("Max takeoff weight exceeds 1.5 times of its empty weight.");
            }
            else
                throw new Exception("Model must not exceed 40 characters.");
        }

        public void DeleteHelicopter(string helicopterId)
        {
            throw new NotImplementedException();
        }
    }
}
