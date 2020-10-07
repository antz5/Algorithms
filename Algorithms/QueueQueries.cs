using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var queries = Convert.ToInt32(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            for (int q= 0;q <queries;q++)
            {
                var input = Console.ReadLine();
                var splitInput = input.Split(' ');
                var value = (Convert.ToInt32(splitInput[0]) == 1)? Convert.ToInt32(splitInput[1]):0;
                switch(Convert.ToInt32(splitInput[0]))
                {
                    case 1:
                        queue.Enqueue(value);
                        break;
                    case 2:
                        queue.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine(queue.Peek());
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
