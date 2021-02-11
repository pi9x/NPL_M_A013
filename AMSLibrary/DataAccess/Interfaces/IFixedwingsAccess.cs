using AMSLibrary.Entities;

namespace AMSLibrary.DataAccess
{
    interface IFixedwingsAccess : IGenericAccess<Fixedwing>, IParkingAccess
    {
        void ChangeType(string fixedwingId, string type);
        void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize);
    }
}
