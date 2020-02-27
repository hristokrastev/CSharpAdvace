using System;
using DateModifier;

namespace DateModifier
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            var dateOne = Console.ReadLine();

            var dateTwo = Console.ReadLine();

            DateModifier.Diff(dateOne, dateTwo);
        }
    }
}
