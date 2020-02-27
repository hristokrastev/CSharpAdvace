using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_MaxMin
{
    class Startup
    {
        static void Main(string[] args)
        {

            var numberOfOperation = int.Parse(Console.ReadLine());

            var stackNumber = new Stack<int>();

            for (int i = 0; i < numberOfOperation; i++)
            {
                var operation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                switch (operation[0])
                {
                    case 1: stackNumber.Push(operation[1]);
                        break;
                    case 2: if (stackNumber.Any())
                            stackNumber.Pop();
                        break;
                    case 3:
                        if (stackNumber.Any())
                            Console.WriteLine(stackNumber.Max());
                        break;
                    case 4:
                        if (stackNumber.Any())
                            Console.WriteLine(stackNumber.Min());
                        break;
                }
            }
            if (stackNumber.Any())
            {
                
                Console.WriteLine(string.Join(", ", stackNumber));
            }
            
        }
    }
}
