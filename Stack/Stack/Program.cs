﻿using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(10);

            // Test kod som visar att det fungerar
            queue.Enqueue(2);
            queue.Enqueue(13);
            queue.Enqueue(40);
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Enqueue(21);
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Clear();
        }
    }
}
