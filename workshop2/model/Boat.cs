using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2.model
{
    public enum BoatType
    {
        Sailboat,
        Motorsailor,
        Motorboat,
        Canoe,
        Other
    }

    struct Boat
    {
        private const string length = "length";
        private const string type = "type";

        public double Length { get; set; }
        public BoatType Type { get; set; }

        public Boat(BoatType type, double length) : this()
        {
            Length = length;
            Type = type;
        }
        public Boat(JObject boatJson)
            : this()
        {          
            Length = (double)boatJson.GetValue(length);
            Type = (BoatType)(int)boatJson.GetValue(type);
        }

        

        public IDictionary ToJson()
        {
            return new Dictionary<string, object>
            {   
                {length, Length},
                {type, Type}
            };
        }
    }
}
