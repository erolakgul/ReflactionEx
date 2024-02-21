using ReflactionEx.Models;

namespace ReflactionEx.Application
{
    public interface IProductRepository //: IRepository<Product>
    {
        List<Product> GetAllProduct();
        Product GetProductByIdAsync(int id);
    }
}
