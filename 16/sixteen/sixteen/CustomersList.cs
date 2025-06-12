using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixteen
{
    public class CustomersList
    {
        public List<Customer> Customers { get; set; }

        public CustomersList()
        {
            Customers = new List<Customer>();
        }
        public CustomersList(params Customer[] customers)
        {
            Customers = new List<Customer>(customers);
        }

        public void AddCustomer(Customer customer)
        {
            if (!Customers.Contains(customer)) Customers.Add(customer);
            else Console.WriteLine("Customer already exists in the list.");
        }
        public void RemoveCustomer(Customer customer)
        {
            if (Customers.Contains(customer)) Customers.Remove(customer);
            else Console.WriteLine("Customer not found in the list.");
        }

        public IEnumerable<Customer> GetCustomersWithPurchases(int minValue, int dayInterval = 7)
        {
            foreach (Customer customer in Customers)
            {
                if (customer.GetValueOfPurchasesOfLastDays(dayInterval) > minValue)
                {
                    yield return customer;
                }
            }
        }

        public override string ToString()
        {
            string result = "Customers List:\n";
            foreach (Customer customer in Customers)
            {
                result += customer.ToString() + "\n";
            }
            return result;
        }
    }
}
