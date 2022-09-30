using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        //foreign keys
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }  
    }
}
