using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();

            var dictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!dictionary.ContainsKey(text[i]))
                {
                    dictionary.Add(text[i], 0);  
                }
                dictionary[text[i]]++;

            }

            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
