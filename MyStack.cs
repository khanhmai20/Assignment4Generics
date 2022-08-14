using System;

namespace HomeWork4
{
    public class MyStack<T> 
    {
        private T[] stack;
        private int count;

        public MyStack()
        {
            stack = new T[0];
            count = 0; 
        }

        public int Count()
        {
            return count; 
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException(); 
            }
            return stack[--count]; 
        }

        public void Push(T item)
        {
            if (count == stack.Length) //resize
            {
                resize(); 
            }
            stack[count++] = item; 
        }

        private void resize()
        {
            T[] replacement = new T[stack.Length * 2 + 1];
            for (int i = 0; i < stack.Length; i++)
            {
                replacement[i] = stack[i]; 
            }

            stack = replacement; 
        }
    }
}

