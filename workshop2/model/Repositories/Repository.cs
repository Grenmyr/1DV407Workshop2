using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.IO;




namespace workshop2.model.Repositories
{
    public abstract class Repository
    {
        const string _connectionString = "mongodb://ooad:ooad@ds063929.mongolab.com:63929/ooadw2";
        protected MongoDatabase _db;
        protected JsonWriterSettings jsonSettings;

        public Repository() 
        {
            var client = new MongoClient(_connectionString);
            _db = client.GetServer().GetDatabase("ooadw2");

            jsonSettings = new JsonWriterSettings { OutputMode = JsonOutputMode.Strict };
        }
    }
}
