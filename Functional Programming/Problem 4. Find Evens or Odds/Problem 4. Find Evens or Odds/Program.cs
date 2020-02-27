using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromTo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var querry = Console.ReadLine();

            var odd = new Predicate<int>((n) => n % 2 != 0);

            var even = new Predicate<int>((n) => n % 2 == 0);

            var predicate = querry == "odd" ? odd : even;

            var result = new List<int>();

            for (int i = fromTo[0]; i <= fromTo[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }

            }

            Console.WriteLine(string.Join(" ", result));

        }

    }
}
