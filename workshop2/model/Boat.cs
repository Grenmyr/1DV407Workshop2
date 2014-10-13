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
    

    class Boat
    {
        private const string length = "length";
        private const string type = "type";

        internal double Length { get; set; }
        internal BoatType Type { get; set; }

        public Boat() 
        {
        }
        public Boat(JObject boatJson)
            
        {          
            Length = (double)boatJson.GetValue(length);
            Type = (BoatType)(int)boatJson.GetValue(type);
        }

        

        public IDictionary ToJson()
        {
            return new Dictionary<string, object>
            {               
                {type, Type},
                {length, Length}
            };
        }
    }
}
