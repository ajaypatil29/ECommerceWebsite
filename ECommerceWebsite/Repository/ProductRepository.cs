using ECommerceWebsite.Data;
using ECommerceWebsite.Models;

namespace ECommerceWebsite.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddProduct(Product prod)
        {

            int result = 0;
            db.products.Add(prod);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var prod = db.products.Where(x => x.ProductId == id).FirstOrDefault();
            if (prod != null)
            {
                db.products.Remove(prod);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return db.products.ToList();
        }

        public Product GetProductById(int id)
        {
            var prod = db.products.Where(x => x.ProductId == id).FirstOrDefault();
            return prod;
        }

        public int UpdateProduct(Product prod)
        {
            int result = 0;
            var p = db.products.Where(x => x.ProductId == prod.ProductId).FirstOrDefault();
            if (p != null)
            {
                p.ProductName=prod.ProductName;
                p.Price=prod.Price; 
                p.CatId=prod.CatId;
                p.CatName =prod.CatName;
                p.Discount=prod.Discount;
                p.Discription   =prod.Discription;
                p.ImageUrl=prod.ImageUrl;
                p.Stock=prod.Stock;

                result = db.SaveChanges();
            }
            return result;
        }
    }
}
