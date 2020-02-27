using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            var listOfNumbers = new Dictionary<int, int>();


            for (int i = 0; i < length; i++)
            {
                var numbers = int.Parse(Console.ReadLine());

                if (listOfNumbers.ContainsValue(numbers))
                {
                    Console.WriteLine(numbers);
                    break;
                }
                else
                {
                    listOfNumbers.Add(i, numbers);
                }
                
            }
        }
    }
}
