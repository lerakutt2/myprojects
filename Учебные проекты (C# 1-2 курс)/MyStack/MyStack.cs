using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class MyStack<T>
    {
        public MyStack(int cap)
        {
            Capacity = cap;
            Count = 0;
            _data = new T[cap];
        }

        // кладёт элемент
        public void Push(T val)
        {
            Count = _currentIndex + 1;
            _data[_currentIndex - 1] = val;
        }

        // убирает верхний элемент
        public void Pop()
        {
            Count = _currentIndex - 1;
            _data[_currentIndex] = default;
        }

        // смотрит верхний элемент
        public T Top()
        {
            return _data[_currentIndex - 1];
        }

        // возвращает массив текущих символов
        public T[] CurrentData()
        {
            T[] values = new T[Count]; 
            for (int i = 0; i < Count; i++)
            {
                values[i] = _data[i];
            }
            return values;
        }
        public int Count
        {
            get
            {
                return _currentIndex;
            }
            private set
            {
                if (value <= Capacity && value >= 0)
                {
                    _currentIndex = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        int _currentIndex;
        public int Capacity { get; private set; }

        // пустой массив
        private T[] _data;
    }
}
