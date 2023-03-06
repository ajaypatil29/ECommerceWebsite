using ECommerceWebsite.Models;
using ECommerceWebsite.Repository;

namespace ECommerceWebsite.Service
{
    public class ProductCatSerivce : IProductCatService
    {
        private readonly IProductCatRepository repo;
        public ProductCatSerivce(IProductCatRepository repo)
        {
            this.repo = repo;
        }
        public int AddCat(ProductCat cat)
        {
           return repo.AddCat(cat);
        }

        public int DeleteCat(int id)
        {
            return repo.DeleteCat(id);
        }

        public IEnumerable<ProductCat> GetAllCat()
        {
            return repo.GetAllCat();
        }

        public ProductCat GetCatById(int id)
        {
            return repo.GetCatById(id); 
        }

        public int UpdateCat(ProductCat cat)
        {
            return repo.UpdateCat(cat);
        }
    }
}
