namespace AMSLibrary.Managements
{
    interface IManagements
    {
        // Airports management
        void CreateAirport(string name, double runwaySize, int fixedwingCapacity, int helicopterCapacity);
        void ParkFixedwing(string airportId, string fixedwingId);
        void ParkHelicopter(string airportId, string helicopterId);
        void UnparkFixedwing(string airportId, string fixedwingId);
        void UnparkHelicopter(string airportId, string helicopterId);

        // Fixedwings management
        void CreateFixedwing(string model, string planeType, double cruiseSpeed, double emptyWeight,
                     double maxTakeoffWeight, double minNeededRunwaySize);
        void ChangeType(string fixedwingId, string type);
        void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize);

        // Helicopters management
        void CreateHelicopter(string model, double cruiseSpeed, double emptyWeight,
                      double maxTakeoffWeight, double range);
    }
}
