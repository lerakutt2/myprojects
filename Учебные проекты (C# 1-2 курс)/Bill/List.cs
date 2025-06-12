using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill
{
    public class List
    {
        public static List<Item> purchases = new List<Item>();
        public static List<Item> items = new List<Item>()
        {
            new Item("Капучино 0.3", 150, 1),
            new Item("Капучино 0.2", 100, 1),
            new Item("Латте 0.3", 160, 1),
            new Item("Латте 0.2", 110, 1),
            new Item("Американо 0.3", 120, 1),
            new Item("Американо 0.2", 100, 1),
            new Item("Круассан", 100, 1),
            new Item("Пирожное", 90, 1),
            new Item("Шоколад", 50, 1),
            new Item("Моккачино 0.3", 150, 1),
            new Item("Чай в чайнике 0.5", 250, 1),
        };
    }
}
