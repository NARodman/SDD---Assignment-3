using MongoDB.Driver;

namespace MongoDBConnector
{
    public class MongoDBConnector
    {
        private readonly MongoClient _client;

        public MongoDBConnector(string connectionString)
        {
            _client = new MongoClient(connectionString);
        }
    }
}


