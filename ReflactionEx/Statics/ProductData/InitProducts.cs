using ReflactionEx.Models;

namespace ReflactionEx.Statics.Data
{
    public class InitProducts
    {
        List<Product> productList = new();
        public InitProducts()
        {
            var products = new Product  { Id = 1, CreateAt = DateTime.Now, Desc = "Vida", IsInStock = true, Price = 20.4 };
            var products2 = new Product { Id = 2, CreateAt = DateTime.Now, Desc = "Civata", IsInStock = true, Price = 22.2 };
            var products3 = new Product { Id = 3, CreateAt = DateTime.Now, Desc = "Pens", IsInStock = true, Price = 24.5 };
            var products4 = new Product { Id = 4, CreateAt = DateTime.Now, Desc = "Kargaburun", IsInStock = true, Price = 23.3 };

            productList.Add(products);
            productList.Add(products2);
            productList.Add(products3);
            productList.Add(products4);
        }

        public List<Product> GetProducts()
        {
            return productList;
        }

        public Product GetProductById(int id)
        {
            return productList.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
