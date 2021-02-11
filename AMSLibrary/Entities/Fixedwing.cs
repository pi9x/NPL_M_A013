using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.Entities
{
    class Fixedwing : IHasId
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public string PlaneType { get; set; }
        public double CruiseSpeed { get; set; }
        public double EmptyWeight { get; set; }
        public double MaxTakeoffWeight { get; set; }
        public double MinNeededRunwaySize { get; set; }
        public string FlyMethod { get; private set; }
        public string AirportId { get; set; }

        public Fixedwing(string model, string planeType, double cruiseSpeed, double emptyWeight,
                         double maxTakeoffWeight, double minNeededRunwaySize)
        {
            Model = model;
            PlaneType = planeType;
            CruiseSpeed = cruiseSpeed;
            EmptyWeight = emptyWeight;
            MaxTakeoffWeight = maxTakeoffWeight;
            MinNeededRunwaySize = minNeededRunwaySize;
            FlyMethod = "Fixed wing";
            AirportId = string.Empty;
        }

        public string GetId() => Id;

        public string GetPrefix() => "FW";

        public void SetId(string id) => Id = id;
    }
}
