using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CustomerService
    {
        public int CustomerId { get; set; }
        public int WorkerId { get; set; }

        public Customer? Customer { get; set; }
        public Worker? Worker { get; set; }
    }
}
