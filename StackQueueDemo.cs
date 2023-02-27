using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructDemo2_27
{
    internal class StackQueueDemo
    {
        List<int> intList = new List<int>();
        Stack<int> intStack = new Stack<int>();
        Queue<int> intQueue = new Queue<int>();


        void Run()
        {
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(7);
            intStack.Push(10);

            int temp1 = intStack.Pop();
            int temp = intStack.Peek();

            if (intStack.Contains(1))
            {
                //dosomething
            }

            for (int i = 0; i < intStack.Count; i++)
            {
                Console.WriteLine($"{intStack.Peek()}");
            }

            while (intStack.Count > 0)
            {
                Console.WriteLine($"{intStack.Pop()}");
            }


            intQueue.Enqueue(1);
            intQueue.Enqueue(3);
            intQueue.Enqueue(4);
            intQueue.Enqueue(7);
            intQueue.Enqueue(10);

            int temp2 = intQueue.Dequeue();
            int temp3 = intQueue.Peek();

        }
    }
}
