using Customer.API.Data;
using Customer.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerContext _context;

        public CustomerRepository(ICustomerContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CreateCustomer(CustomerEntity customer)
        {
            await _context.Customers.InsertOneAsync(customer);

        }

        public async Task<IEnumerable<CustomerEntity>> GetCustomerList()
        {
            return await _context.Customers.Find(p => true).ToListAsync();
        }
    }
}
