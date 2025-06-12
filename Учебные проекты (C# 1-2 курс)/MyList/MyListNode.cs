using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyListNode<T>
    {
        /// <summary>
        /// Создает объект MyListNode
        /// </summary>
        /// <param name="item">Значение</param>
        /// <param name="prev">Предыдущий элемент</param>
        /// <param name="next">Последующий элемент</param>
        public MyListNode(T item, MyListNode<T> prev, MyListNode<T> next)
        {
            val = item;
            this.prev = prev;
            this.next = next;
        }

        public MyListNode() { }

        public T val;
        public MyListNode<T> prev;
        public MyListNode<T> next;
    }
}
