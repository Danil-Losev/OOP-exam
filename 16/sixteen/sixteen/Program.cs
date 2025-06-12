using sixteen;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer("Bob", "123 Main St", "555-1234");
        customer1.AddPurchase(new Purchase("Laptop", DateTime.Now.AddDays(-5), 600));
        customer1.AddPurchase(new Purchase("Mouse", DateTime.Now.AddDays(-2), 500));

        Customer customer2 = new Customer("Alice", "456 Elm St", "555-5678");
        customer2.AddPurchase(new Purchase("Keyboard", DateTime.Now.AddDays(-10), 500));
        customer2.AddPurchase(new Purchase("Monitor", DateTime.Now.AddDays(-1), 1100));

        Customer customer3 = new Customer("Charlie", "789 Oak St", "555-8765");
        customer3.AddPurchase(new Purchase("Tablet", DateTime.Now.AddDays(-3), 200));
        customer3.AddPurchase(new Purchase("Phone", DateTime.Now.AddDays(-8), 1000));


        Customer customer4 = new Customer("Dave", "321 Pine St", "555-4321");
        customer4.AddPurchase(new Purchase("Printer", DateTime.Now.AddDays(-8), 150));
        customer4.AddPurchase(new Purchase("Scanner", DateTime.Now.AddDays(-4), 250));

        CustomersList customersList = new CustomersList(customer1, customer2, customer3, customer4 );

        Console.WriteLine(customersList.ToString());

        Console.WriteLine("Customers with purchases over $1000 in the last 7 days:");
        foreach (Customer customer in customersList.GetCustomersWithPurchases(1000))
        {
            Console.WriteLine(customer.ToString());
            Console.WriteLine("Value of last 7 days: " + customer.GetValueOfPurchasesOfLastDays(7) + '\n');
        }


    }
}