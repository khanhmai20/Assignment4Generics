using System;
using System.Collections.Generic;

namespace HomeWork4
{
    public class MyList<T> 
    {
        private T[] array;
        private int count;

        public MyList()
        {
            array = new T[0];
            count = 0; 
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                resize(); 
            }
            array[count++] = item; 
        }

        public T Remove(int index)
        {
            if (checkIndex(index))
            {
                T item = array[index]; 
                for (int i = index; i < count-1; i++)
                {
                    array[i] = array[i + 1]; 
                }
                count--;
                return item; 
            }else
            {
                throw new IndexOutOfRangeException(); 
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < count; i++)
            {
                T item = array[i];
                if (item.Equals(element)) return true; 
            }
            return false; 
        }

        public void Clear()
        {
            count = 0; 
        }

        public void InsertAt(T element, int index)
        {
            if (count == array.Length)
            {
                resize(); 
            }
            if (checkIndex(index))
            {
                 T intake = element; 
                 T outake;

                 for (int i = index; i < count; i++)
                 {
                     outake = array[i];
                     array[i] = intake;
                     intake = outake; 
                 }
                 array[count++] = intake; 
             }else
             {
                 throw new IndexOutOfRangeException(); 
             }
        }

        public T Find(int index)
        {
            if (checkIndex(index))
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public int Count()
        {
            return count; 
        }

        public void print()
        {
            int i = 0;
            while (i < count)
            {
                Console.Write($"{Find(i)} ");
                i++;
            }
            Console.WriteLine();
        }

        private bool checkIndex(int index)
        {
            if (index >= count) return false;
            else if (index < 0) return false;
            else return true; 
        }

        private void resize()
        {
            T[] replacement = new T[array.Length * 2 + 1];
            for (int i = 0; i < count; i++)
            {
                replacement[i] = array[i]; 
            }
            array = replacement; 
        }
    }
}

