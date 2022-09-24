﻿using ecom.order.application.Order;
using ecom.order.domain.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom.order.service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderApplication _orderApplication;

        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderApplication orderApplication, ILogger<OrderController> logger)
        {
            _orderApplication = orderApplication;
            _logger = logger;
        }

        [HttpPost("", Name = "SubmitOrder")]        
        public async Task<IEnumerable<ecom.order.domain.Order.Order>> Submit(OrderVM order) => await _orderApplication.AddAsync(order);     
        
    }
}
