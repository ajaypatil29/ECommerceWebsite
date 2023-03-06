using ECommerceWebsite.Models;

namespace ECommerceWebsite.Service
{
    public interface IProductCatService
    {
        IEnumerable<ProductCat> GetAllCat();
        ProductCat GetCatById(int id);
        int AddCat(ProductCat cat);
        int UpdateCat(ProductCat cat);
        int DeleteCat(int id);
    }
}
