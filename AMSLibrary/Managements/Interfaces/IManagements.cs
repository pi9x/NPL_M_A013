namespace AMSLibrary.Managements
{
    interface IManagements
    {
        // Airports management
        string AllAirports();
        string SelectedAirport(string airportId);
        void CreateAirport(string name, double runwaySize, int fixedwingCapacity, int helicopterCapacity);
        void ParkFixedwing(string airportId, string fixedwingId);
        void ParkHelicopter(string airportId, string helicopterId);
        void UnparkFixedwing(string airportId, string fixedwingId);
        void UnparkHelicopter(string airportId, string helicopterId);
        void DeleteAirport(string airportId);

        // Fixedwings management
        string AllFixedwings();
        string SelectedFixedwing(string fixedwingId);
        void CreateFixedwing(string model, string planeType, double cruiseSpeed, double emptyWeight,
                     double maxTakeoffWeight, double minNeededRunwaySize);
        void ChangeType(string fixedwingId, string type);
        void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize);
        void DeleteFixedwing(string fixedwingId);

        // Helicopters management
        string AllHelicopters();
        string SelectedHelicopter(string helicopterId);
        void CreateHelicopter(string model, double cruiseSpeed, double emptyWeight,
                      double maxTakeoffWeight, double range);
        void DeleteHelicopter(string helicopterId);
    }
}
