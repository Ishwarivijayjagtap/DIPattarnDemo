using DIPattarnDemo.Models;
using DIPattarnDemo.Repository;

namespace DIPattarnDemo.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repo;
        public ProductService(IProductRepository repo)
        {
            this.repo = repo;
        }
        public int AddProduct(Product pro)
        {
            return repo.AddProduct(pro);
        }

        public int DeleteProduct(int id)
        {
            return repo.DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
           return repo.GetProducts();
        }

        public int UpdatProduct(Product pro)
        {
            return repo.UpdatProduct(pro);
        }
    }
}
