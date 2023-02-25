using Customer.API.Entities;
using MongoDB.Driver;

namespace Customer.API.Data
{
    public interface ICustomerContext
    {
        IMongoCollection<CustomerEntity> Customers { get; }
    }
}
