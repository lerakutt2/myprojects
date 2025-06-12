using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    public class MyVector<T> : IEnumerable<T>
    {
        class MyVectEnum : IEnumerator<T>
        {
            public MyVectEnum(T[] data, int size)
            {
                _data = data;
                this.size = size;
                index = -1;
            }
            public bool MoveNext() 
            {
                if (index < size - 1)
                {
                    index++;
                    return true;
                }
                return false;
            }
            public T Current 
            { 
                get => _data[index];
                set => _data[index] = value;
            }

            object IEnumerator.Current => _data[index];

            public void Reset() { index = -1; }

            public void Dispose() { }

            T[] _data;
            int index;
            readonly int size;
        }

        public MyVector(int cap)
        {
            Capacity = cap;
            _data = new T[Capacity];
            index = -1;
        }

        public int Size
        {
            get => index + 1;
        }

        public int Capacity;
        T[] _data;
        int index;

        public int Index
        {
            get => index;
            set
            {
                if (value >= Capacity)
                {
                    Reserve(Capacity * 2);
                    index = value;
                } 
                else index = value; 
            }
        }

        /// <summary>
        /// Для обращения по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        /// <summary>
        /// Добавляет элемент в конец списка
        /// </summary>
        /// <param name="val"></param>
        public void Add(T val)
        {
             Index++;
            _data[Index] = val;
        }

        /// <summary>
        /// Выставляет значение элемента вектора с указанным индексом
        /// </summary>
        /// <param name="ind"></param>
        /// <param name="val"></param>
        public void SetValue(int ind, T val)
        {
            if (ind >= Capacity) 
            {
                throw new ArgumentOutOfRangeException();
            }
            if (ind > Index)
            {
                Index = ind;
            }
            _data[ind] = val;
        }

        /// <summary>
        /// Изменяет размер вектора
        /// </summary>
        /// <param name="newSize"></param>
        public void Resize(int newSize)
        {
            T[] oldData = _data;
            _data = new T[newSize];
            for (int i = 0; i < Math.Min(Capacity, newSize); i++)
            {
                _data[i] = oldData[i];
            }
            if (newSize >= Capacity)
            {
                for (int i = Capacity; i < newSize; i++)
                {
                    _data[i] = default;
                }
            }
            Capacity = newSize;
            if (Index >= newSize)
            {
                Index = newSize - 1;
            }
        }

        /// <summary>
        /// Изменяет размер зарезервированного пространства (Capacity), но не меняет размер (Size).
        /// </summary>
        /// <param name="newSize"></param>
        public void Reserve(int newSize)
        {
            if (newSize > Index)
            {
                Resize(newSize);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        /// <summary>
        /// Изменяет значение Capacity таким образом, он совпадал со значением размера (Size) .
        /// </summary>
        public void ShrinkToFit()
        {
            T[] oldData = _data;
            _data = new T[Size];
            for (int i = 0; i < Size; i++)
            {
                _data[i] = oldData[i];
            }
            Capacity = Size;
        }

        public T[] ToArray()
        {
            T[] newData = new T[Size];
            for (int i = 0; i < Size; i++)
            {
                newData[i] = _data[i];
            }
            return newData;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new MyVectEnum(_data, Size);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyVectEnum(_data, Size);
        }
    }
}
