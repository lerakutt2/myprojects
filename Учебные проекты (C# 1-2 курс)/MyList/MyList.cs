using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class MyList<T> : IEnumerable<T>
    {
        class MyListEnum : IEnumerator<T>
        {
            public MyListEnum(MyListNode<T> first)
            {
                this.first = first;
                node = first;
                nodeIsFirst = true;
            }
            public bool MoveNext()
            {
                if (nodeIsFirst)
                {
                    nodeIsFirst = false;
                    return true;
                }
                if (node.next != null)
                {
                    node = node.next;
                    return true;
                }
                return false;
            }
            public MyListNode<T> Current
            {
                get => node;
                set => node = value;
            }

            object IEnumerator.Current => node;

            T IEnumerator<T>.Current => node.val;

            public void Reset() { node = first; }

            public void Dispose() { }

            MyListNode<T> node;
            MyListNode<T> first;
            bool nodeIsFirst;
        }

        /// <summary>
        /// Добавляет в начало
        /// </summary>
        /// <param name="val"></param>
        public void Prepend(T val) 
        {
            if (first == null) // когда хотим создать первый элемент
            {
                first = new MyListNode<T>(val, null, last);
                last = first;
            }   
            else // когда уже есть элементы
            {
                first = new MyListNode<T>(val, null, first);
                first.next.prev = first;
            }
        }

        /// <summary>
        /// Добавляет в конец
        /// </summary>
        /// <param name="val"></param>
        public void Append(T val)
        {
            if (first == null)
            {
                first = new MyListNode<T>(val, null, last);
                last = first;
            }
            else
            {
                last = new MyListNode<T>(val, last, null);
                last.prev.next = last;
            }
        }

        /// <summary>
        /// Вставляет элемент на место index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void Insert(int index, T val) 
        {
            MyListNode<T> temp = FindAt(index);

            if (temp.prev == null) Prepend(val);   
            else
            {
                temp.prev.next = new MyListNode<T>(val, temp.prev, temp);
                temp.prev = temp.prev.next;
            }
        }

        MyListNode<T> FindAt(int index)
        {
            MyListNode<T> temp = first;
            for (int i = 0; i < index; i++) temp = temp.next;
            return temp;
        }

        /// <summary>
        /// Удаление по значению (удаляется первое вхождение)
        /// </summary>
        /// <param name="val"></param>
        /// <returns>Есть ли такой элемент</returns>
        public bool Remove(T val)
        {
            MyListNode<T> temp = FindValue(val);

            if (temp != null)
            {
                Delete(temp);
            }
            return temp != null;
        }

        MyListNode<T> FindValue(T val)
        {
            MyListNode<T> temp = first;
            for (int i = 0; i < Size; i++)
            {
                if (temp.val.Equals(val))
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }

        /// <summary>
        /// Узнает, содержится ли элемент в списке
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public bool Contains(T val)
        {            
            return FindValue(val) != null;
        }

        /// <summary>
        /// Удаление по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            Delete(FindAt(index));
        }

        /// <summary>
        /// Вспомогательная функция, удаляющая конкретный элемент
        /// </summary>
        /// <param name="temp"></param>
        void Delete(MyListNode<T> temp)
        {
            if (temp.next == null && temp.prev == null)
            {
                // если элемент остался один, мы просто делаем список пустым
                first = null;
                last = null;
            }
            else if (temp.next != null && temp.prev != null)
            {
                // когда элемент в середине
                temp.next.prev = temp.prev;
                temp.prev.next = temp.next;
            }
            else if (temp.prev != null)
            {
                // элемент в конце
                last = temp.prev;
                last.next = null;
            }
            else if (temp.next != null)
            {
                // элемент в начале
                first = temp.next;
                first.prev = null;
            }
        }

        /// <summary>
        /// Ищет элемент по значению
        /// </summary>
        /// <param name="val">Значение элемента</param>
        /// <returns>Индекс элемента с указанным значением</returns>
        public int Find(T val)
        {
            MyListNode<T> temp = first;
            int index = 0;
            for (int i = 0; i < Size; i++)
            {
                if (temp.val.Equals(val))
                {
                    break;
                }
                index++;
                temp = temp.next;
            }
            return index;
        }

        /// <summary>
        /// Получить элемент по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T At(int index)
        {
            return FindAt(index).val;
        }

        /// <summary>
        /// Меняет значение по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void SetValue(int index, T val) 
        {
            FindAt(index).val = val;
        }

        public T[] ToArray()
        {
            T[] array = new T[Size];
            MyListNode<T> temp = first;
            for (int i = 0; i < Size; i++)
            {
                array[i] = temp.val;
                temp = temp.next;
            }
            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnum(first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyListEnum(first);
        }

        /// <summary>
        /// Вычисляет размер списка 
        /// </summary>
        public int Size
        {
            get
            {
                int i = 0;
                MyListNode<T> temp = first;
                while (temp != null)
                {
                    temp = temp.next;
                    i++;
                }
                return i;
            }
        }

        public T this[int index]
        {
            get => ToArray()[index];
            set => ToArray()[index] = value;
        }

        MyListNode<T> first;
        MyListNode<T> last;
    }
}
