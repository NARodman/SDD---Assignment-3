using Xunit;
using Testcontainers.MongoDb;


namespace MongoDBConnector.Tests
{
    public class MongoDBConnectorTest : IAsyncLifetime
    {
        private readonly MongoDbContainer _mongoDbContainer;

        public MongoDBConnectorTest()
        {
            _mongoDbContainer = new MongoDbBuilder().Build();
        }

        public async Task InitializeAsync() => await _mongoDbContainer.StartAsync();
        public async Task DisposeAsync() => await _mongoDbContainer.DisposeAsync();

        [Fact]
        public void Ping_ShouldReturnTrue_WhenMongoDBIsRunning()
        {
            var connector = new MongoDBConnector(_mongoDbContainer.GetConnectionString());
            Assert.True(connector.Ping());
        }
    }
}
