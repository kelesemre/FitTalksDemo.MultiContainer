using Customer.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.API.Data
{
    public interface ICustomerContext
    {
        IMongoCollection<CustomerEntity> Customers { get; }
    }
}
