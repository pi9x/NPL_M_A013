namespace AMSLibrary.Entities
{
    class Helicopter : IHasId
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public double CruiseSpeed { get; set; }
        public double EmptyWeight { get; set; }
        public double MaxTakeoffWeight { get; set; }
        public double Range { get; set; }
        public string FlyMethod { get; set; }
        public string AirportId { get; set; }

        public Helicopter(string model, double cruiseSpeed, double emptyWeight, double maxTakeoffWeight, double range)
        {
            Model = model;
            CruiseSpeed = cruiseSpeed;
            EmptyWeight = emptyWeight;
            MaxTakeoffWeight = maxTakeoffWeight;
            Range = range;
            FlyMethod = "Rotated wing";
            AirportId = string.Empty;
        }

        public string GetId() => Id;

        public string GetPrefix() => "RW";

        public void SetId(string id) => Id = id;

        public void Park(string airportId) => AirportId = airportId;

        public void Unpark() => AirportId = string.Empty;
    }
}
