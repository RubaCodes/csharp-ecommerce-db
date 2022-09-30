using csharp_ecommerce_db;

Console.WriteLine("Ricerca e inserimento nel Database");

//Inserimento alcuni campi

//using (ECommerceContext db = new ECommerceContext()) {
//    Customer customer1 = new Customer() {Name = "Paolo" ,Surname = "Rossi", Email =" rossi@email.it" };
//    Customer customer2 = new Customer() { Name = "Mario", Surname = "Verdi", Email = " verdi@email.it" };
//    Customer customer3 = new Customer() { Name = "Luca", Surname = "Bianchi", Email = " bianchi@email.it" };
//    db.Add(customer1);
//    db.Add(customer2);
//    db.Add(customer3);
//    db.SaveChanges();
//}

//using (ECommerceContext db = new ECommerceContext())
//{
//    Employee employee1 = new Employee() { Name = "Paolo", Surname = "Rossi", Level = " beginner" };
//    Employee employee2 = new Employee() { Name = "Mario", Surname = "Verdi", Level = "intermediate" };
//    Employee employee3 = new Employee() { Name = "Luca", Surname = "Bianchi", Level = "advanced" };

//    db.Add(employee3);
//    db.Add(employee2);
//    db.Add(employee1);
//    db.SaveChanges();
//}


//Crud  su tabella customer

using (ECommerceContext db = new ECommerceContext())
{
    Console.WriteLine("Query ricerca per utente di nome Mario");
    Customer risultato = db.Customers.Where( x => x.Name == "Mario").First();
    Console.WriteLine($"{risultato.Name} - {risultato.Surname} - {risultato.Email}");

    Console.WriteLine("Query ricerca di tutta la tabella employee");

    List<Employee> result = (from e in db.Employees select e).ToList<Employee>();
    foreach (Employee e in result) {
        Console.WriteLine($"{e.Name} - {e.Surname} - {e.Level}");
    }
}
