using System;

namespace Problem_1._Action_Point
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Print(input);
        }
        
        static void Print(string[] names)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
