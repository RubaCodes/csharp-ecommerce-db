

namespace csharp_ecommerce_db
{
    internal class Payment
    {
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        //foreign keys
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
