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

    /*
    public class dataCollection  // EmployeeRepository
    {
        private readonly IMongoCollection<addData> _collection;

        public dataCollection(IMongoDatabase database, string collection)
        {
            _collection = database.GetCollection<addData>(collection);
        }

        public List<addData> getData()  // GetEmployees
        {
            return _collection.Find(_ => true).ToList();
        }

        public async Task UpdateEmployee(string employeeId, addData updatedEmployee)
        {
            var filter = Builders<addData>.Filter.Eq("_id", ObjectId.Parse(employeeId)); // Assuming "_id" is the ObjectId field
            var update = Builders<addData>.Update
                .Set("name", updatedEmployee.locationName)
                .Set("[123,123]", updatedEmployee.coordinates);

            // Replace the entire document with the updated employee data
            await _collection.ReplaceOneAsync(filter, updatedEmployee);
        }
    }
    */
}
