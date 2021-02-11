using AMSLibrary.Entities;

namespace AMSLibrary.DataAccess
{
    class HelicoptersAccess : GenericAccess<Helicopter>, IHelicoptersAccess
    {
        public HelicoptersAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public void Park(string helicopterId, string airportId)
        {
            Helicopter helicopter = GetById(helicopterId);
            helicopter.Park(airportId);
            Update(helicopter);
        }

        public void Unpark(string helicopterId)
        {
            Helicopter helicopter = GetById(helicopterId);
            helicopter.Unpark();
            Update(helicopter);
        }
    }
}
