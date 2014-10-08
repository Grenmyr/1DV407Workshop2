using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MongoDB.Driver;


namespace workshop2.model.Repositories
{
    class MemberRepository : Repository
    {
        const string collectionName = "memberRegister";


        internal void Save(Member member, Member updatedMember)
        {
            var options = new MongoUpdateOptions().Flags = UpdateFlags.Upsert;
                _db.GetCollection(collectionName).Update(
                    new QueryDocument (member.ToJson()),
                    new UpdateDocument(updatedMember.ToJson()),options);
        }
        internal IEnumerable<Member> GetAll() 
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
