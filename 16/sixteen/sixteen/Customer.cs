using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixteen
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public List<Purchase> Purchases { get; set; }

        public Customer(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Purchases = new List<Purchase>();
        }

        public Customer()
        {
            Name = "Default Name";
            Address = "Default Address";
            PhoneNumber = "000-000-0000";
            Purchases = new List<Purchase>();
        }

        public void AddPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
        }

        public void RemovePurchase(Purchase purchase)
        {
            if (Purchases.Contains(purchase)) Purchases.Remove(purchase);
            else Console.WriteLine("Purchase not found in the customer's purchase list.");
        }

        public int GetValueOfPurchasesOfLastDays(int days)
        {
            DateTime minDate = DateTime.Now.AddDays(-days);
            int totalValue = 0;
            foreach (Purchase purchase in Purchases)
            {
                if (purchase.PurchaseDate >= minDate)
                {
                    totalValue += purchase.Cost;
                }
            }
            return totalValue;
        }

        public override string ToString()
        {
            string customerInfo = "--Name: " + Name + "\n" +
                                  "  Address: " + Address + "\n" +
                                  "  Phone Number: " + PhoneNumber + "\n" +
                                  "  Purchases:\n";

            foreach (Purchase purchase in Purchases)
            {
                customerInfo += "    " + purchase.ToString() + "\n";
            }
            return customerInfo;
        }
    }
}
