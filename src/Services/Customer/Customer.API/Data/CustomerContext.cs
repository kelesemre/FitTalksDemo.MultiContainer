using Customer.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Customer.API.Data
{
    public class CustomerContext : ICustomerContext
    {
        public IMongoCollection<CustomerEntity> Customers { get; }
        public CustomerContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Customers = database.GetCollection<CustomerEntity>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            CustomerContextSeed.SeedData(Customers);
        }
    }
}
