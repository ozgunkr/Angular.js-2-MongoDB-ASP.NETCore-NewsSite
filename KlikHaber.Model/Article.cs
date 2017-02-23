using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KlikHaber.Model
{
    public class Article
    {
        public ObjectId Id {get; set;}

        [BsonElement("Category")]
        public string Category { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Body")]
        public string Body{ get; set; }
    }
}
