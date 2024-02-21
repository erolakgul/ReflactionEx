namespace ReflactionEx.Application
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAllProduct();
        T GetProductByIdAsync(int id);
    }
}
