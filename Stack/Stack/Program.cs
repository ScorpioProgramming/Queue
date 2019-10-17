using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(10);
            stack.Enqueue(2);
            stack.Enqueue(13);
            stack.Enqueue(40);
            stack.Enqueue(27);
            Console.WriteLine(stack.Peek());
            stack.Dequeue();
            Console.WriteLine(stack.Peek());
            stack.Clear();
        }
    }
}
