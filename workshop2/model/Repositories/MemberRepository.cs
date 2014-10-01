using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace workshop2.model.Repositories
{
    class MemberRepository : Repository
    {
        const string collectionName = "memberRegister";

        public void Add(Member member)
        {
            _db.GetCollection(collectionName).Insert(new BsonDocument(member.ToJson()));
        }
        public IEnumerable<Member> GetAll() 
        { 
            var memberList = new List<Member>();
            foreach (var memberBson in _db.GetCollection(collectionName).FindAll()) 
            {
                var JsonObject = (JObject)JsonConvert.DeserializeObject(memberBson.ToJson(jsonSettings));
                memberList.Add(new Member(JsonObject));
            }
            return memberList;
        }
    }
}
