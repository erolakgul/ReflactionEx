namespace ReflactionEx.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Desc { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsInStock { get; set; }
    }
}
