using ECommerceWebsite.Data;
using ECommerceWebsite.Models;

namespace ECommerceWebsite.Repository
{
    public class ProductCatRepository : IProductCatRepository
    {
        private readonly ApplicationDbContext db;

        public ProductCatRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddCat(ProductCat cat)
        {
                int result = 0;
            db.Cats.Add(cat);
            result= db.SaveChanges();
            return result;
        }

        public int DeleteCat(int id)
        {
            int result = 0;
            var cat = db.Cats.Where(x => x.CatId == id).FirstOrDefault();
            if (cat != null)
            {
                db.Cats.Remove(cat);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<ProductCat> GetAllCat()
        {
            return db.Cats.ToList();
        }

        public ProductCat GetCatById(int id)
        {
            var cat = db.Cats.Where(x => x.CatId == id).FirstOrDefault();
            return cat;
        }

        public int UpdateCat(ProductCat cat)
        {
            int result = 0;
            var p = db.Cats.Where(x => x.CatId == cat.CatId).FirstOrDefault();
            if (cat != null)
            {
                p.CatName=cat.CatName;

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
