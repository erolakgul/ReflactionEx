using ReflactionEx.Models;

namespace ReflactionEx.Application
{
    public interface IProductRepository
    {
        List<Product> GetAllProduct();
        Product GetProductByIdAsync(int id);
    }
}
