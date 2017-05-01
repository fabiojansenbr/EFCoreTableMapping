using EFCoreTableMapping.Models;
using System.Collections.Generic;

namespace EFCoreTableMapping.Data.Seed
{
    public class SeedDataBase
    {
        public static IEnumerable<Customer> CustomersList()
        {
            return new[]
            {
                new Customer("Customer 1","customer1@domain.com"),
                new Customer("Customer 2","customer2@domain.com"),
                new Customer("Customer 3","customer3@domain.com"),
                new Customer("Customer 4","customer4@domain.com"),
            };
        }
    }
}
