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
    class Member : ICloneable
    {
        private string _name;
        private string _socialSecurityNumber;

        private const string name = "name";
        private const string memberNumber = "memberNumber";
        private const string socialSecurityNumber = "socialSecurityNumber";
        private const string boats = "boats";


        internal List<Boat> Boats { get; set; }
        internal string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Member name can not be empty");
                }
                _name = value;
            }
        }
        internal string SocialSecurityNumber
        {
            get
            {
                return _socialSecurityNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Social security number can not be empty");
                }
                _socialSecurityNumber = value;
            }
        }
        internal long MemberNumber {get; set;}

        public Member()
        {

            MemberNumber = DateTime.UtcNow.ToFileTimeUtc();
            Boats = new List<Boat>();
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


        public object Clone()
        {
            var member = (Member)MemberwiseClone();
            member.Boats = Boats.ToList();
            return member;
        }
    }
   
}
