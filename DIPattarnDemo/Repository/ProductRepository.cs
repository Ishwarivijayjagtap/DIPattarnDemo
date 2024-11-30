using DIPattarnDemo.Data;
using DIPattarnDemo.Models;

namespace DIPattarnDemo.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProduct(Product pro)
        {
            int result = 0;
            db.Products.Add(pro);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var p = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
            if (p != null)
            {
                db.Products.Remove(p);
                result = db.SaveChanges();
            }
            return result;
        }

        public Product GetProductById(int id)
        {
            var res=(from p in db.Products
                      join c in db.Categories on p.CategoryId equals c.CategoryId
                     where p.ProductId ==id
                     select new Product
                     {
                         ProductId = p.ProductId,
                         ProductName = p.ProductName,
                         Price = p.Price,
                         CategoryId = c.CategoryId, 
                         CategoryName= c.CategoryName,
                         ImageUrl=p.ImageUrl

                     }).FirstOrDefault();
            return res;
        }

        public IEnumerable<Product> GetProducts()
        {
            var result = (from p in db.Products
                          join c in db.Categories on p.CategoryId equals c.CategoryId
                          select new Product
                          {
                              ProductId = p.ProductId,
                              ProductName = p.ProductName,
                              Price = p.Price,
                              CategoryId = p.CategoryId,
                              ImageUrl = p.ImageUrl

                          }).ToList();
            return result;
        }

        public int UpdatProduct(Product pro)
        {
            int result = 0;
            var p = db.Products?.Where(x => x.ProductId == pro.ProductId).SingleOrDefault();
            if (p != null)
            {
                p.ProductName = pro.ProductName;
                p.Price = pro.Price;
                p.CategoryId = pro.CategoryId;
                p.ImageUrl = pro.ImageUrl;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}   