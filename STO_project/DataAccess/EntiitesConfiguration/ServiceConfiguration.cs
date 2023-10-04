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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            // Define table name (optional)
            //builder.ToTable("Services");

            // Configure primary key
            builder.HasKey(s => s.Id);

            // Configure properties
            //builder.Property(s => s.ServiceId).HasColumnName("ServiceId");
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Price).IsRequired();

            // Configure navigation property (Customers)
            builder.HasMany(s => s.Customers)
                .WithMany(c => c.Services)
                .UsingEntity(j => j.ToTable("CustomerServices"));

            // Configure navigation property (Workers)
            builder.HasMany(s => s.Workers)
                .WithMany(w => w.Services)
                .UsingEntity(j => j.ToTable("WorkerServices"));

            // You can add more configuration as needed for your specific use case
        }
    }
}
