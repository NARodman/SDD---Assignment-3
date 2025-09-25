using MongoDB.Bson;
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

        public bool Ping() {
            try
            {
                var database = _client.GetDatabase("admin");
                var command = new BsonDocument("ping", 1);
                var result = database.RunCommand<BsonDocument>(command);
                return result.Contains("ok") && result["ok"] == 1;
            }
            catch
            {
                return false;
        }
    }
}

    
}


