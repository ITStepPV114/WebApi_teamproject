using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public static class SeedData
    {
        public static void SeedCustomers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", PhoneNumber = "555-555-5555" },
                new Customer { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", PhoneNumber = "555-555-5556" }
            // Add more customer data as needed
            );
        }

        public static void SeedServices(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Oil Change", Price = 50.00 },
                new Service { Id = 2, Name = "Brake Inspection", Price = 75.00 }
            // Add more service data as needed
            );
        }

        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(
                new Worker { Id = 1, FirstName = "Mike", LastName = "Smith", Email = "mike@example.com", PhoneNumber = "555-555-5557", HireDate = DateTime.Parse("2022-01-15"), HourlyWage = 20.00 },
                new Worker { Id = 2, FirstName = "Emily", LastName = "Johnson", Email = "emily@example.com", PhoneNumber = "555-555-5558", HireDate = DateTime.Parse("2022-02-20"), HourlyWage = 18.50 }
            // Add more worker data as needed
            );
        }
    }
}
