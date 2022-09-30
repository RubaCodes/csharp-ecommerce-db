
namespace csharp_ecommerce_db
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //liste
        public List<Order> Orders { get; set; }
    }
}

