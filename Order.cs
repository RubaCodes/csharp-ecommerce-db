
namespace csharp_ecommerce_db
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        //foreign keys
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }  
        // liste
        List<Payment> Payments {get; set; }
        List<Product> Products { get; set; }
    }
}
