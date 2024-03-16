using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{

    public class DynamicArray<T> : IEnumerable<T>
    {
        T[] array;
        int count;

        public DynamicArray()
        {
            array = new T[1];
            count = 0;

        }
        public DynamicArray(int size)
        {
            array = new T[size];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }
        public bool IsFull()
        {
            if (array.Length == count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ExpandArray()
        {
            T[] newArray = new T[array.Length * 2];
            Array.Copy(array, newArray, count);

            array = newArray;
        }
        public void Add(T value)
        {
            if (IsFull())
            {
                ExpandArray();
            }
            array[count] = value;
            count++;
        }
        public void Clear()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default(T);
            }
            count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in array)
            {
                if (object.Equals(item,default(T)))
                {
                    break;
                }
                yield return item;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
