using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Queue_
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var childrens = Console.ReadLine().Split(" ");
            var removeNum = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(childrens);

            int currentIndex = 1;

            while (queue.Count > 1)
            {
                var currentChildren = queue.Dequeue();

                if (currentIndex == removeNum)
                {
                    Console.WriteLine($"Removed {currentChildren}");
                    currentIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentChildren);
                }

                currentIndex++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
