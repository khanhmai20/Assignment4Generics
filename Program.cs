using HomeWork4;

namespace Homework4
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Testing Stack
            Console.WriteLine("-------------Testing Stack-------------");
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());

            //Testing List
            Console.WriteLine("-------------Testing List-------------");
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Count());
            list.print(); 
         
            //Console.Write(list.Find(-1));
            //Console.Write(list.Find(3));

            list.InsertAt(10, 2);
            list.InsertAt(12, 0);
            list.InsertAt(11, 3);
            Console.WriteLine(list.Count());
            list.print(); 
            

            Console.Write($"{list.Contains(10)} {list.Contains(11)} {list.Contains(20)}");
            Console.WriteLine(); 

            Console.WriteLine(list.Remove(2));
            list.print();
            Console.WriteLine(list.Remove(0));
            list.print();

            //
        }
    }
}
