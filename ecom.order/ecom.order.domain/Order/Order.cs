using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.order.domain.Order
{
    public class Order
    {
        public string? OrderId { get; set; }
        public string? ProductId { get; set; }
        public int ProductCount { get; set; }
        public int OrderPrice { get; set; }
        public string OrderState { get; set; }
    }
}
