using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.EntiitesConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            

            // Configure primary key
            builder.HasKey(c => c.Id);

            // Configure properties
            //builder.Property(c => c.Id).HasColumnName("CustomerId");
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
            builder.Property(c => c.PhoneNumber).HasMaxLength(20);

            // Configure navigation property (Services)
            builder.HasMany(c => c.Services)
                .WithMany(s => s.Customers)
                .UsingEntity(j => j.ToTable("CustomerServices"));

            // You can add more configuration as needed for your specific use case
        }
    }
}
