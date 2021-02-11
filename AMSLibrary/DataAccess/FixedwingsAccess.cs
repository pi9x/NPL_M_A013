using AMSLibrary.Entities;

namespace AMSLibrary.DataAccess
{
    class FixedwingsAccess : GenericAccess<Fixedwing>, IFixedwingsAccess
    {
        public FixedwingsAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public void ChangeMinNeededRunwaySize(string fixedwingId, double minNeededRunwaySize)
        {
            Fixedwing fixedwing = GetById(fixedwingId);
            fixedwing.ChangeMinNeededRunwaySize(minNeededRunwaySize);
            Update(fixedwing);
        }

        public void ChangeType(string fixedwingId, string type)
        {
            Fixedwing fixedwing = GetById(fixedwingId);
            fixedwing.ChangeType(type);
            Update(fixedwing);
        }

        public void Park(string fixedwingId, string airportId)
        {
            Fixedwing fixedwing = GetById(fixedwingId);
            fixedwing.Park(airportId);
            Update(fixedwing);
        }

        public void Unpark(string fixedwingId)
        {
            Fixedwing fixedwing = GetById(fixedwingId);
            fixedwing.Unpark();
            Update(fixedwing);
        }
    }
}
