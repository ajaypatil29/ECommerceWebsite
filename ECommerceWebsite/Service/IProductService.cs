using ECommerceWebsite.Models;

namespace ECommerceWebsite.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);
    }
}
