
namespace csharp_ecommerce_db
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        List<Order> Orders {get; set;}
    }
}
