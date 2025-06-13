using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyeight
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Customer(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Customer()
        {
            Name = "Default Name";
            Email = "";
            PhoneNumber = "";
        }

        public void SubscribeToOrder(Order order)
        {
            order.GoodsAdded += HandleGoodsAdded;
            order.GoodsRemoved += HandleGoodsRemoved;
            order.GoodsCounted += HandleGoodsCounted;
        }

        protected void HandleGoodsAdded(object sender, GoodsEventArgs e)
        {
            Console.WriteLine( Name + " received notification: " + e.Action + " - " + e.Goods.ToString());
        }

        protected void HandleGoodsRemoved(object sender, GoodsEventArgs e)
        {
            Console.WriteLine(Name + " received notification: " + e.Action + " - " + e.Goods.ToString());
        }

        protected void HandleGoodsCounted(object sender, ListEventArgs e)
        {
            Console.WriteLine(Name + " received notification: " + e.Action + " - Total goods count: " + e.GoodsList.Count);
        }
    }
}
