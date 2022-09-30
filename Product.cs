
namespace csharp_ecommerce_db
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //liste
        List<Order> Orders { get; set; }
    }
}
