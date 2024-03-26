using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace _30051522
{
    public class addData
    {
        [BsonId]
        public ObjectId ID { get; set; }

        [BsonElement("Name")]
        public string locationName{ get; set; }

        [BsonElement("Coordinates")]
        public List<double> coordinates { get; set; }
    }
}
