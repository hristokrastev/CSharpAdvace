using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Queue_Ex
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputRowOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var nNUmberOfInt = Console.ReadLine().Split(" ").Select(int.Parse);

            var stackOfNumbers = new Queue<int>(nNUmberOfInt);

            var numbersToPush = inputRowOne[0];

            var numbersToPop = inputRowOne[1];

            var presentInTheStack = inputRowOne[2];

            for (int i = 0; i < numbersToPop; i++)
            {
                stackOfNumbers.Dequeue();
            }


            if (stackOfNumbers.Contains(presentInTheStack))
            {
                Console.WriteLine("true");
            }
            else if (stackOfNumbers.Any())
            {
                Console.WriteLine(stackOfNumbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
