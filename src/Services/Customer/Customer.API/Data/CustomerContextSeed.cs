using Customer.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.API.Data
{
    public class CustomerContextSeed
    {
        public static void SeedData(IMongoCollection<CustomerEntity> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertMany(GetPreconfigureProducts());
            }
        }

        private static IEnumerable<CustomerEntity> GetPreconfigureProducts()
        {
            return new List<CustomerEntity>()
            {
                new CustomerEntity()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Alice",
                    Surname = "Alison",
                    Email = "alice.son@gmail.com"
                },
                 new CustomerEntity()
                {
                    Id = "602d2149e773f2a3990b47f4",
                    Name = "Bob",
                    Surname = "Alison",
                    Email = "bob.son@gmail.com"
                },
                  new CustomerEntity()
                {
                    Id = "602d2149e773f2a3990b47f3",
                    Name = "Claire",
                    Surname = "Alison",
                    Email = "cla.son@gmail.com"
                },
                   new CustomerEntity()
                {
                    Id = "602d2149e773f2a3990b47f2",
                    Name = "Daniel",
                    Surname = "Alison",
                    Email = "dany.son@gmail.com"
                },
            };
        }
    }
}
