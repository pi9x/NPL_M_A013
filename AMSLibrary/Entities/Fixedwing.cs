namespace AMSLibrary.Entities
{
    class Fixedwing : IHasId, IParkable, IShowable
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

        public void Park(string airportId) => AirportId = airportId;

        public void Unpark() => AirportId = string.Empty;

        public void ChangeType(string type) => PlaneType = type;

        public void ChangeMinNeededRunwaySize(double minNeededRunwaySize) => MinNeededRunwaySize = minNeededRunwaySize;

        public string ShortInfo()
        {
            if (AirportId != string.Empty)
                return $"{Id}     {PlaneType}         {AirportId}       {Model}\n";
            else
                return $"{Id}     {PlaneType}            -          {Model}\n";
        }

        public string FullInfo()
        {
            return $"ID:                     {Id}\n" +
                   $"Model:                  {Model}\n" +
                   $"Plane type:             {PlaneType}\n" +
                   $"Cruise speed:           {CruiseSpeed}\n" +
                   $"Empty weight:           {EmptyWeight}\n" +
                   $"Max takeoff weight:     {MaxTakeoffWeight}\n" +
                   $"Min needed runway size: {MinNeededRunwaySize}\n" +
                   $"Fly method:             {FlyMethod}\n" +
                   $"Park in airport:        {AirportId}";
        }
    }
}
