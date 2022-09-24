using ecom.order.domain.Order;

namespace ecom.order.application.Order
{
    public interface IOrderApplication
    {
        Task<IEnumerable<ecom.order.domain.Order.Order>> AddAsync(OrderVM product);
    }
}
