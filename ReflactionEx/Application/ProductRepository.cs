using ReflactionEx.Models;
using ReflactionEx.Statics.Data;

namespace ReflactionEx.Application
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProduct()
        {
            return new InitProducts().GetProducts();
        }

        public Product GetProductByIdAsync(int id)
        {
            return new InitProducts().GetProductById(id);
        }
    }
}
