using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System.Linq;
using Amazon.Runtime.Documents;

namespace _30051522
{
    internal class dbConfig
    {
        private const string db_username = "kenul_h3rath";
        private const string db_password = "A1B9265cbf7889";

        // Custom database
        //private const string db_name = "test";
        //public string db_collection = "testCollection";

        // Shipwrecks database
        private const string db_name = "sample_geospatial";
        public string db_collection = "shipwrecks";

        private const string db_connection = "mongodb+srv://" +
                                             db_username +
                                             ":" +
                                             db_password +
                                             "@unicluster.ot8lsa9.mongodb.net/?" +
                                             "retryWrites=true&w=majority&appName=uniCluster";

        public IMongoDatabase v_database;

        // Constructor
        public dbConfig()
        {
            init();
        }

        // Initialize the connection
        void init()
        {
            // Connect to MongoDB server
            MongoClient client = new MongoClient(db_connection);

            // Access the database
            v_database = client.GetDatabase(db_name);
        }

        // CREATE
        public void insertData(addData insertData)
        {
            // Access the collection
            var collection = v_database.GetCollection<addData>(db_collection);

            try
            {
                collection.InsertOne(insertData);

                MessageBox.Show("Data inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured - >" + ex);

            }
        }

        // READ for custom database
        public IEnumerable<BsonDocument> getData()
        {
            // Access the collection
            var collection = v_database.GetCollection<BsonDocument>(db_collection);

            // Retrieve data from the collection
            var documents = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

            return documents;
        }

        // UPDATE
        public void updateData(ObjectId v_id, addData insertData)
        {
            // Access the collection
            var collection = v_database.GetCollection<addData>(db_collection);

            var filter = Builders<addData>.Filter.Eq("_id", v_id);
            var update = Builders<addData>.Update.Set("Name", insertData.locationName)
                .Set("Coordinates", insertData.coordinates);

            var result = collection.UpdateOne(filter, update);

            if (result.ModifiedCount == 1)
            {
                MessageBox.Show("Data updated successfully");
            }
            else
            {
                MessageBox.Show("Data update failed");
            }

        }

        // DELETE
        public void deleteData(ObjectId v_id)
        {
            // Access the collection
            var collection = v_database.GetCollection<addData>(db_collection);

            var filter = Builders<addData>.Filter.Eq("_id", v_id);

            var result = collection.DeleteOne(filter);

            if (result.DeletedCount == 1)
            {
                MessageBox.Show("Data deleted successfully");
            }
            else
            {
                MessageBox.Show("Data delete failed");
            }
        }

        // READ for Shipwrecks database
        public IEnumerable<BsonDocument> testReadData()
        {
            // Access the collection
            var collection = v_database.GetCollection<BsonDocument>(db_collection);

            // Define the projection to include only specific fields
            var projection = Builders<BsonDocument>.Projection
                .Include("feature_type")
                .Include("coordinates");

            // Retrieve data from the collection with the specified projection
            var documents = collection.Find(Builders<BsonDocument>.Filter.Empty)
                                      .Project(projection)
                                      .ToList();

            // Return the list of extracted documents
            return documents;
        }


    }
}
