using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    public class Item
    {
        public string name { get; set; }
        public int cost { get; set; }
        public int amount { get; set; }

        public Item(string name, int cost, int amount)
        {
            this.name = name;
            this.cost = cost;
            this.amount = amount;
        }

        public Item(Item item)
        {
            this.name = item.name;
            this.cost = item.cost;
            this.amount = item.amount;
        }
    }
}
