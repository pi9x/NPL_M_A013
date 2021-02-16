using System;
using System.Collections.Generic;
using System.Text;

namespace AMSLibrary.Entities
{
    class Airport : IHasId, IShowable
    {
        public string Id { get; set; }
        
        public string Name { get; set; }

        public double RunwaySize { get; set; }

        public int FixedwingCapacity { get; set; }

        public int HelicopterCapacity { get; set; }

        public List<string> FixedwingIds { get; set; }

        public List<string> HelicopterIds { get; set; }

        public Airport(string name, double runwaySize, int fixedwingCapacity, int helicopterCapacity)
        {
            Name = name;
            RunwaySize = runwaySize;
            FixedwingCapacity = fixedwingCapacity;
            HelicopterCapacity = helicopterCapacity;
            FixedwingIds = new List<string>();
            HelicopterIds = new List<string>();
        }

        public string GetId() => Id;

        public string GetPrefix() => "AP";

        public void SetId(string id) => Id = id;

        public void ParkFixedwing(string fixedwingId)
        {
            if (FixedwingIds.Count < FixedwingCapacity)
                FixedwingIds.Add(fixedwingId);
            else
                throw new Exception("Exceeded fixedwing capacity!");
        }

        public void UnparkFixedwing(string fixedwingId)
        {
            if (!FixedwingIds.Remove(fixedwingId))
                throw new Exception($"Fixedwing {fixedwingId} does not park in airport {Id}.");
        }

        public void ParkHelicopter(string helicopterId)
        {
            if (HelicopterIds.Count < HelicopterCapacity)
                HelicopterIds.Add(helicopterId);
            else
                throw new Exception("Exceeded helicopter capacity!");
        }

        public void UnparkHelicopter(string helicopterId)
        {
            if (!HelicopterIds.Remove(helicopterId))
                throw new Exception($"Helicopter {helicopterId} does not park in airport {Id}.");
        }

        public string ShortInfo() => $"{Id}     {Name}\n";

        public string FullInfo()
        {
            StringBuilder fixedwingIds = new StringBuilder();
            foreach (string id in FixedwingIds)
                fixedwingIds.Append(id).Append(' ');

            StringBuilder helicopterIds = new StringBuilder();
            foreach (string id in HelicopterIds)
                helicopterIds.Append(id).Append(' ');

            return $"Id:               {Id}\n" +
                   $"Name:             {Name}\n" +
                   $"Runway size:      {RunwaySize}\n" +
                   $"Capacity:\n" +
                   $"   - Fixedwing:   {FixedwingCapacity}\n" +
                   $"   - Helicopter:  {HelicopterCapacity}\n" +
                   $"Current parking:\n" +
                   $"   - Fixedwings:  {fixedwingIds}\n" +
                   $"   - Helicopters: {helicopterIds}";
        }
    }
}
