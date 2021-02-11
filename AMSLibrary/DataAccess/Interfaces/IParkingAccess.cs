namespace AMSLibrary.DataAccess
{
    interface IParkingAccess
    {
        void Park(string airplaneId, string airportId);
        void Unpark(string airplaneId);
    }
}
