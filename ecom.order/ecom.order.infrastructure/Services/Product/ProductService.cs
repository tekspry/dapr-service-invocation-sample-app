using Dapr.Client;
using ecom.order.Extensions;

namespace ecom.order.infrastructure.Product
{
    public class ProductService : IProductService
    {
        private readonly HttpClient client;

        private readonly DaprClient daprClient;
        public ProductService(HttpClient client)//, DaprClient daprClient)
        {
            this.client = client;
            //this.daprClient = daprClient;
        }
        public async Task<string> UpdateProductQuantity(string id, int quantity)
        {

            //await daprClient.InvokeMethodAsync<string>(HttpMethod.Post, "product", "UpdateProductQuantity" );
            //Console.WriteLine($"order infra Dapr port: {client.}");
            
            var response = await client.PostAsJson<string>($"product/product/{id}/updatequnatity/{quantity}", string.Empty);
            Console.WriteLine($"order infra response: {response.Content}");
            //return await response.ReadContentAs<string>();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
    }
}
