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
    struct Member
    {
        private const string name = "name";
        private const string memberNumber = "memberNumber";
        private const string socialSecurityNumber = "socialSecurityNumber";
        private const string boats = "boats";


        public List<Boat> Boats { get; set; }
        public string Name {get; set;}
        public string SocialSecurityNumber {get; set;}
        public long MemberNumber {get; set;}

        public Member(string name, long memberNumber, string socialSecurityNumber)
            : this()
        {
            Boats = new List<Boat>();
            Name = name;
            MemberNumber = memberNumber;
            SocialSecurityNumber = socialSecurityNumber;
            
        }

        internal Member(JObject memberJson)
            : this()
        {
            Boats = memberJson.GetValue(boats).ToList().ConvertAll(JsonBoat => new Boat((JObject) JsonBoat));
            Name = memberJson.GetValue(name).ToString();
            MemberNumber = (long)memberJson.GetValue(memberNumber);
            SocialSecurityNumber = memberJson.GetValue(socialSecurityNumber).ToString();
        }

        internal IDictionary ToJson()
        {
            return new Dictionary<string, object>
            {   
                {boats, Boats.ConvertAll(boat => boat.ToJson())},
                {memberNumber, MemberNumber},
                {name, Name},
                {socialSecurityNumber, SocialSecurityNumber}
            };
        }
  
    }
   
}
