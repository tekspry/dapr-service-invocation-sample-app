namespace ecom.order.infrastructure.Product
{
    public interface IProductService
    {
        Task<string> UpdateProductQuantity(string id, int quantity);
    }
}
