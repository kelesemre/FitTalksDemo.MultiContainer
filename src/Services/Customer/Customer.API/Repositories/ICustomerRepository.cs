using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.API.Entities;


namespace Customer.API.Repositories
{
    public interface ICustomerRepository
    {
        Task CreateCustomer(CustomerEntity customer);
        Task<IEnumerable<CustomerEntity>> GetCustomerList();
    }
}
