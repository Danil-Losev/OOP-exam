using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixteen
{
    public class Purchase
    {
        public string ItemName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Cost { get; set; }

        public Purchase(string itemName, DateTime purchaseDate, int cost)
        {
            ItemName = itemName;
            PurchaseDate = purchaseDate;
            Cost = cost;
        }

        public Purchase()
        {
            ItemName = "Default Item";
            PurchaseDate = DateTime.Now;
            Cost = 0;
        }

        public override string ToString()
        {
            return "Item: " + ItemName + ", Date: " + PurchaseDate.ToShortDateString() + ", Cost: $" + Cost;
        }

    }
}
