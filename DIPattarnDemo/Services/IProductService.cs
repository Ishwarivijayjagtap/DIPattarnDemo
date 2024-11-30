using DIPattarnDemo.Models;

namespace DIPattarnDemo.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        int AddProduct(Product pro);
        int UpdatProduct(Product pro);
        int DeleteProduct(int id);
    }
}
