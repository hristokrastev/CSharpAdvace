using System;
using System.Collections.Generic;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());
            var uniqueUsernnames = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();

                uniqueUsernnames.Add(input);
            }

            foreach (var name in uniqueUsernnames)
            {
                Console.WriteLine(name);
            }
        

        }
    }
}
