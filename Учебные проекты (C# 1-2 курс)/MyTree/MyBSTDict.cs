using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    internal class MyBSTDictionary<T1, T2> : IEnumerable<T1> where T1 : IComparable
    {
        class Item : IComparable<Item>
        {
            public T1 _key;
            public T2 _value;

            public Item(T1 key, T2 value)
            {
                _key = key;
                _value = value;
            }
            public int CompareTo(Item other)
            {
                return other._key.CompareTo(_key);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                sb.Append("Key: ");
                sb.Append(_key);
                sb.Append(", ");
                sb.Append("Value: ");
                if (_value != null)
                    sb.Append(_value.ToString());
                sb.Append("]");

                return sb.ToString();
            }
        }

        //public void Insert(T1 key, T2 value)
        //{
        //    tree.Add(new Item(key, value));
        //}
        //public T2 Find(T1 key)
        //{
        //    var item = tree.Find(new Item(key, default));
        //    return item._value;
        //}
        //public override string ToString()
        //{
        //    return tree.Show();
        //}

        public IEnumerator<T1> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //MyTree<Item> tree = new MyTree<Item>();
    }
}
