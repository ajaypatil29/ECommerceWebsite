using ECommerceWebsite.Models;

namespace ECommerceWebsite.Repository
{
    public interface IProductCatRepository
    {
        IEnumerable<ProductCat> GetAllCat();
        ProductCat GetCatById(int id);
        int AddCat(ProductCat cat);
        int UpdateCat(ProductCat cat);
        int DeleteCat(int id);
    }
}
