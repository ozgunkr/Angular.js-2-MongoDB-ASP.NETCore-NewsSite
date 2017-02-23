using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace KlikHaber.DataAccess
{
    
    public class MongoConnectionHandler<T> where T : IGenericDataRepository
    {
        
       
            public IMongoCollection<T> MongoCollection { get; private set; }

        public MongoConnectionHandler()
        {
            const string connectionString = "mongodb://localhost";

            //// Get a thread-safe client object by using a connection string
            var mongoClient = new MongoClient(connectionString);

            //// Get a reference to a server object from the Mongo client object
            //var mongoServer = mongoClient.GetServer();
            
            //// from the Mongo server object
            const string databaseName = "db";
            var db = mongoClient.GetDatabase(databaseName);

            //// Get a reference to the collection object from the Mongo database object
            //// The collection name is the type converted to lowercase + "s"
            MongoCollection = db.GetCollection<T>(typeof(T).Name.ToLower() + "s");
        }
        

    }
}
