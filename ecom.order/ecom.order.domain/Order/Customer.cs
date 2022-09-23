using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.order.domain.Order
{
    public class Customer
    {
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public int ContactNumber { get; set; }
        public string Address { get; set; } = String.Empty;     
    }
}
