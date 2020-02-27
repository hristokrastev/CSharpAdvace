using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            var uniqueElements = new SortedSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var elements = Console.ReadLine().Split();
                foreach (var item in elements)
                {
                    uniqueElements.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
