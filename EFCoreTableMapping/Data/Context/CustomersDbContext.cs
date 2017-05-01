using EFCoreTableMapping.Data.Extensions;
using EFCoreTableMapping.Data.Map;
using EFCoreTableMapping.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTableMapping.Data.Context
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CustomerMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
