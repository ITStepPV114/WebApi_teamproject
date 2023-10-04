using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class WorkerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public double HourlyWage { get; set; }
        public IEnumerable<ServiceDto>? Services { get; set; }
        public IEnumerable<CustomerDto>? Customers { get; set; }
    }
}
