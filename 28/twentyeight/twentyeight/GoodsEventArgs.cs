using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyeight
{
    public class GoodsEventArgs
    {
        public Goods Goods { get; set; }
        public string Action { get; set; }

        public GoodsEventArgs(Goods goods, string action)
        {
            Goods = goods;
            Action = action;
        }

        public override string ToString()
        {
            return "Action: " + Action + ", Goods: " + Goods.ToString();
        }
    }
}
