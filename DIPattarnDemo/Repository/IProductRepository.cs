using DIPattarnDemo.Models;

namespace DIPattarnDemo.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        int AddProduct(Product pro);
        int UpdatProduct(Product pro);
        int DeleteProduct(int id);
    }
}
