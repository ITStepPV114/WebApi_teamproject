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
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            // Define table name (optional)
            //builder.ToTable("Workers");

            // Configure primary key
            builder.HasKey(w => w.Id);

            // Configure properties
            builder.Property(w => w.Id).HasColumnName("WorkerId");
            builder.Property(w => w.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(w => w.LastName).IsRequired().HasMaxLength(50);
            builder.Property(w => w.Email).IsRequired().HasMaxLength(100);
            builder.Property(w => w.PhoneNumber).HasMaxLength(20);
            builder.Property(w => w.HireDate).IsRequired();
            builder.Property(w => w.HourlyWage).IsRequired();

            // Configure navigation property (Services)
            builder.HasMany(w => w.Services)
                .WithMany(s => s.Workers)
                .UsingEntity(j => j.ToTable("WorkerServices"));

            // Configure navigation property (Customers)
            //builder.HasMany(w => w.Customers)
            //    .WithMany(c => c.Services)
            //    .UsingEntity(j => j.ToTable("CustomerWorkers"));

            // You can add more configuration as needed for your specific use case
        }
    }
}
