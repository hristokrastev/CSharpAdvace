using System;
using System.Collections.Generic;
using System.Linq;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBox = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var secondBox = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var boxQueue = new Queue<int>(firstBox);

            var boxStack = new Stack<int>(secondBox);

            var sum = 0;

            var collectionOfItems = 0;

            while (boxQueue.Any() && boxStack.Any())
            {

                sum = boxQueue.Peek() + boxStack.Peek();
                if (sum % 2 == 0)
                {
                    collectionOfItems += sum;
                    boxStack.Pop();
                    boxQueue.Dequeue();
                }
                else
                {
                    boxQueue.Enqueue(boxStack.Pop());
                }

            }

            if (boxQueue.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (collectionOfItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collectionOfItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collectionOfItems}");
            }


        }
    }
}
