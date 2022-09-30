

namespace csharp_ecommerce_db
{
    internal class Payment
    {
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        //foreign keys
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
