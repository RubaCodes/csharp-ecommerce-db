
namespace csharp_ecommerce_db
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        //foreign keys
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  
        // liste
        public List<Payment> Payments {get; set; }
        public List<Product> Products { get; set; }
    }
}
