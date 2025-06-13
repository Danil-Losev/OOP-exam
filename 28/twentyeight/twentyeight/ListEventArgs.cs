using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyeight
{
    public class ListEventArgs
    {
        public List<Goods> GoodsList;
        public string Action;
        public ListEventArgs(List<Goods> inGoodsList, string inAction)
        {
            GoodsList = inGoodsList;
            Action = inAction;
        }

        override public string ToString()
        {
            return "Action: " + Action + ", Goods Count: " + GoodsList.Count;
        }
    }
}
