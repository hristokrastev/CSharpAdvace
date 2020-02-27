using System;
using System.Linq;

namespace Problem_3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNumber = (min) =>
            {
                int minValue = int.MaxValue;

                foreach (var nums in min)
                {
                    if (nums < minValue)
                    {
                        minValue = nums;
                    }
                }
                return minValue;
            };

            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(smallestNumber(input));
        }
    }
}
