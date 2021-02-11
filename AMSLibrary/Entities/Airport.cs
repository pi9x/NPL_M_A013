using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AMSLibrary.Entities
{
    class Airport : IHasId
    {
        public string Id { get; set; }
        
        public string Name { get; set; }

        public double RunwaySize { get; set; }

        public int FixedwingCapacity { get; set; }

        public int HelicopterCapacity { get; set; }

        public List<string> FixedwingIds { get; set; }

        public List<string> HelicopterIds { get; set; }

        //public Airport()
        //{
        //    FixedwingIds = new List<string>();
        //    HelicopterIds = new List<string>();
        //}

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
    }
}
