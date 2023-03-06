using ECommerceWebsite.Models;

namespace ECommerceWebsite.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);
    }
}
