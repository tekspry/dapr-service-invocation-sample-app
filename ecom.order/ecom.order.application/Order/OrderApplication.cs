using ecom.order.domain.Order;
using ecom.order.infrastructure.Product;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom.order.application.Order
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IProductService _productService;

        private readonly ILogger<OrderApplication> logger;

        public OrderApplication(IProductService productService, ILogger<OrderApplication> logger)
        {
            _productService = productService;
            this.logger = logger;
        }
        public async Task<IEnumerable<ecom.order.domain.Order.Order>> AddAsync(OrderVM orderVM)
        {
            var orders = new List<ecom.order.domain.Order.Order>();

            var productPrice = await _productService.UpdateProductQuantity(orderVM.ProductId, orderVM.ProductCount);

            var order = new ecom.order.domain.Order.Order() 
            { 
                ProductCount = orderVM.ProductCount,
                OrderPrice = orderVM.ProductCount * productPrice,

            };



            //foreach (var order in orderList.orders)
            //{
            //    var productId = await _productService.UpdateProductQuantity(order.ProductId, order.ProductCount);
            //    orders.Add(order);
            //}

            return orders;
        }
    }
}
