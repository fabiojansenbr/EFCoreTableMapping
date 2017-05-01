using EFCoreTableMapping.Data.Extensions;
using EFCoreTableMapping.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTableMapping.Data.Map
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public override void Map(EntityTypeBuilder<Customer> builder)
        {

            builder.ToTable("Customers");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(150)")
                .IsRequired();

        }
    }
}
