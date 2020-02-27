using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique_Stack
{
    class Startup
    {
        static void Main(string[] args)
        {
            var clothesInTheBox = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var capacityOfTheRack = int.Parse(Console.ReadLine());

            var clothesStack = new Stack<int>(clothesInTheBox);

            var numbersOfRackNeeded = 1;

            var sumForCapacity = 0;


            while (clothesStack.Count > 0)
            {
                sumForCapacity += clothesStack.Peek();
                if (sumForCapacity <= capacityOfTheRack)
                {
                    clothesStack.Pop();
                }
                else
                {
                    numbersOfRackNeeded++;
                    sumForCapacity = 0;
                }
            }
            Console.WriteLine(numbersOfRackNeeded);
        }
    }
}
