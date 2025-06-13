using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyeight
{
    public delegate void GoodsEventHandler(object sender, GoodsEventArgs e);
    public delegate void GoodsCountedEventHandler(object sender, ListEventArgs e);

    public class Order
    {
        public List<Goods> GoodsList { get; set; }

        public Order()
        {
            GoodsList = new List<Goods>();
        }

        public Order(params Goods[] goods)
        {
            GoodsList = new List<Goods>();
            foreach (Goods item in goods)
            {
                if (item != null)
                {
                    GoodsList.Add(item);
                    OnGoodsAdded(item, "Added to order");
                }
            }
        }

        public void AddGoods(Goods goods)
        {
            if (!GoodsList.Contains(goods))
            {
                GoodsList.Add(goods);
                OnGoodsAdded(goods, "Added to order");
            }
            else Console.WriteLine("Goods already in the order.");
        }

        public void RemoveGoods(Goods goods)
        {
            if (GoodsList.Contains(goods))
            {
                GoodsList.Remove(goods);
                OnGoodsRemoved(goods, "Removed from order");
            }
            else Console.WriteLine("Goods not found in the order.");
        }

        public void CountGoods()
        {
            if (GoodsList.Count > 0)
            {
                int totalPrice = 0;
                foreach (Goods item in GoodsList)
                {
                    totalPrice += item.Price;
                }
                Console.WriteLine("Total price of goods in the order: " + totalPrice);
                OnGoodsCounted(GoodsList, "Total order list");
            }
            else Console.WriteLine("No goods in the order to count.");
        }

        public event GoodsEventHandler GoodsAdded;
        public event GoodsEventHandler GoodsRemoved;
        public event GoodsCountedEventHandler GoodsCounted;

        protected virtual void OnGoodsAdded(Goods goods, string action)
        {
            GoodsAdded?.Invoke(this, new GoodsEventArgs(goods, action));
        }

        protected virtual void OnGoodsRemoved(Goods goods, string action)
        {
            GoodsRemoved?.Invoke(this, new GoodsEventArgs(goods, action));
        }

        protected virtual void OnGoodsCounted(List<Goods> goodsList, string message)
        {
            GoodsCounted?.Invoke(this, new ListEventArgs(goodsList, message));
        }
    }
}
