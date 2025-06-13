using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyeight
{
    public class Goods
    {
        string name;
        int price;

        public Goods(string inName, int inPrice)
        {
            name = inName;
            price = inPrice;
        }

        public Goods()
        {
            name = "Default Name";
            price = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return "Name: " + name + ", Price: " + price;
        }

        public override bool Equals(object obj)
        {
            if (obj is Goods goods)
            {
                return name == goods.name && price == goods.price;
            }
            return false;
        }

        public static bool operator ==(Goods g1, Goods g2)
        {
            if (g1 is null || g2 is null)
                return false;
            else if (ReferenceEquals(g1, g2))
                return true;
            else if (g1.GetType() != g2.GetType())
                return false;
            return g1.name == g2.name && g1.price == g2.price;
        }
        public static bool operator !=(Goods g1, Goods g2)
        {
            return !(g1 == g2);
        }
    }
}
