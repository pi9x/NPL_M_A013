using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

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

        public string GetId() => Id;

        public string GetPrefix() => "RW";

        public void SetId(string id) => Id = id;
    }
}
