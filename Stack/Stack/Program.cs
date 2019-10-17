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
            Console.WriteLine(stack.Peek());    // 2 ska skrivas och skrivs???
            stack.Dequeue();                    // Dequeue() måste vara fel på.
            Console.WriteLine(stack.Peek());    // 13 ska skrivas men det blir 40????
            stack.Clear();
        }
    }
}
