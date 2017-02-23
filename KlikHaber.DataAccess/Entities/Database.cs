using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Driver.Builders;


namespace KlikHaber.DataAccess
{
    [BsonIgnoreExtraElements]
    public class MongoDB : GenericDataRepository
    {

        
            public void Category()
            {
                Categories = new List<string>();
            }

            public string Name { get; set; }

            [BsonDateTimeOptions(DateOnly = true)]
            public DateTime Date { get; set; }

            public List<string> Categories { get; set; }

            public bool Title { get; set; }

            public bool Body { get; set; }

        /*
        public MongoDB Database
        {
            get
            {
                string connectionString = "mongodb://localhost";
                MongoClient client = new MongoClient(connectionString);
                MongoServer server = client.GetServer();
                MongoDatabase database = server.GetDatabase("test"); //name of the database

                return database;
            }
        }


        public void CreateCustomer(Customer customer)
        {
            var collection = Database.GetCollection("Customers");
            collection.Insert(customer);
        }


        public Customer GetCustomer(ObjectId objectid
        {
            //Query: Get Customer.id == supported objectid
            IMongoQuery query = Query<Customer>.EQ(e => e.Id, objectid);
            var collection = Database.GetCollection("Customers");
            BsonDocument bsonCustomer = collection.FindOne(query);
            Customer customer = BsonSerializer.Deserialize<Customer>(bsonCustomer);

            return customer;
        }


        public void DeleteCustomer(ObjectId objectId)
        {
            var query = Query<Customer>.EQ(e => e.Id, objectId);
            var collection = Database.GetCollection("Customers");

            collection.Remove(query);

        }


        public List<Customer> GetAllCustomer()
        {
            var collection = Database.GetCollection("Customers");
            MongoCursor<BsonDocument> Bsoncustomers = collection.FindAll();
            List<Customer> customers = new List<Customer>();
            foreach (var bsoncustomer in Bsoncustomers)
            {
                var cus = BsonSerializer.Deserialize<Customer>(bsoncustomer);
                customers.Add(cus);
            }
        }

        public List<Customer> GetByAddress6(string address)
        {
            IMongoQuery query = Query<Customer>.EQ(x => x.Addresses[0].Address6 == address);
            return GetByQuery(query);
        }


        public List<Customer> GetByQuery(IMongoQuery query)
        {
            var collection = Database.GetCollection("Customers");
            MongoCursor<BsonDocument> Bsoncustomers = collection.Find(query);
            List<Customer> customers = new List<Customer>();
            foreach (var bsoncustomer in Bsoncustomers)
            {
                var cus = BsonSerializer.Deserialize<Customer>(bsoncustomer);
                customers.Add(cus);
            }
            return customers;
        }
        */
    }
}
