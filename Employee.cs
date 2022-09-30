namespace csharp_ecommerce_db
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Level { get; set; }
        List<Order> Orders {get; set;}
    }
}
