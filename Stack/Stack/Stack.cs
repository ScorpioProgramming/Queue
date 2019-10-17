using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {
        /// <summary>
        /// Själva stacken
        /// </summary>
        private int[] stack;

        /// <summary>
        /// Stackpekaren som också håller reda på hur många element det finns i stacken
        /// </summary>
        private int count = 0;

        public int Count
        { get { return count; }  }

        public int this[int i]
        {
            get { return stack[i]; }
            set { stack[i] = value; }
        }

        public Stack()
        {
            stack = new int[10];
        }

        public Stack(int size)
        {
            stack = new int[size];
        }

        /// <summary>
        /// Lägger till element överst i stacken
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            if (stack.Length == count)
                ReSize((int)(count * 1.3));

            stack[count] = value;
            count++;
        }

        /// <summary>
        /// Tar bort översta elementet i stacken
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            count--;
            if (count == stack.Length / 2 && stack.Length > 100)
                ReSize((int)(count * 1.3));

            return stack[count];
        }

        /// <summary>
        /// Lägger till ett element sist i kön
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            if (stack.Length == count)
                ReSize((int)(count * 1.3));

            stack[count] = value;
            count++;
        }

        /// <summary>
        /// Tar bort första värdet i stacken och flyttar alla element ett steg framåt
        /// </summary>
        public int Dequeue()
        {
            int[] temp = stack;

            stack = new int[temp.Length];

            for (int i = 1; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    stack[j] = temp[i];
                }
            }

            count--;
            return stack[count];
        }

        /// <summary>
        /// Returnerar översta värdet i stacken utan att ta bort det
        /// </summary>
        /// <returns></returns>
        public int Peek_end()
        {
            return stack[count - 1];
        }


        public int Peek()
        {
            return stack[0];
        }

        /// <summary>
        /// Ändrar stoleken på stacken
        /// </summary>
        /// <param name="size">Nya storleken på stacken</param>
        private void ReSize(int size)
        {
            int[] temp = stack;

            stack = new int[size];

            for (int i = 0; i < count; i++)
            {
                stack[i] = temp[i];
            }
        }


        /// <summary>
        /// Rensar stcken
        /// </summary>
        public void Clear()
        {
            count = 0;
            stack = new int[10];
        }
    }
}
