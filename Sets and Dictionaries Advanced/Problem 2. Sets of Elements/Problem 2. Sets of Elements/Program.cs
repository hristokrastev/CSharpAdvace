using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthOfTheSets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var n = lengthOfTheSets[0];

            var m = lengthOfTheSets[1];

            var setN = new HashSet<int>();

            var setM = new HashSet<int>();

            var output = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                var valuesN = int.Parse(Console.ReadLine());
                setN.Add(valuesN);
            }
            for (int i = 0; i < m; i++)
            {
                var valueM = int.Parse(Console.ReadLine());
                setM.Add(valueM);
            }

            var setMin = Math.Min(setM.Count, setN.Count);
            var setMax = Math.Max(setM.Count, setN.Count);

            if (setM.Count > setN.Count)
            {
                foreach (var values in setN)
                {
                    if (setM.Contains(values))
                    {
                        output.Add(values);
                    }
                }
            }
            else
            {
                foreach (var value in setM)
                {
                    if (setN.Contains(value))
                    {
                        output.Add(value);
                    }
                }
            }


            Console.WriteLine(string.Join(" ", output));
        }
    }
}
