using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueNew
{
    internal class MyQueue<T>
    {
        public MyQueue(int size)
        {
            _data = new T[size];
            indexIn = 0;
            indexOut = 0;
            Count = 0;
        }

        T[] _data;
        public int Capacity 
        {
            get => _data.Length;
        }
        int indexIn;
        int IndexIn
        {
            get => indexIn;
            set
            {
                if (value >= Capacity)
                {
                    indexIn = 0;
                }
                else
                {
                    indexIn = value;
                }
            }
        }

        int indexOut;
        int IndexOut
        {
            get => indexOut;
            set
            {
                if (value >= Capacity)
                {
                    indexOut = 0;
                }
                else
                {
                    indexOut = value;
                }
            }
        }
        int count;
        public int Count
        {
            get => count;
            set
            {
                if (value > Capacity)
                {
                    throw new ArgumentOutOfRangeException("overfilled");
                }
                else if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("empty");
                }
                else
                {
                    count = value;
                }
            }
        }

        /// <summary>
        /// Добавляет элемент в конец очереди
        /// </summary>
        /// <param name="val">Элемент для добавления</param>
        public void Enqueue(T val)
        {
            Count++;
            _data[IndexIn++] = val;
        }

        /// <summary>
        /// Получает первый элемент и удаляет его из очереди
        /// </summary>
        /// <returns>Первый элемент</returns>
        public T Dequeue()
        {
            Count--;
            T last = _data[IndexOut];
            _data[IndexOut++] = default;
            return last;
        }

        /// <summary>
        /// Получает первый элемент на выход
        /// </summary>
        /// <returns>Первый элемент</returns>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _data[indexOut];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Все элементы очереди</returns>
        public T[] ToArray()
        {
            T[] actualData = new T[Count];
            int actualIndexOut = IndexOut;
            for (int i = 0; i < Count; i++)
            {
                actualData[i] = _data[IndexOut++];
            }
            IndexOut = actualIndexOut;
            return actualData;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
