using System;
using System.Linq;

namespace Matrics_Multidimensional_Arrays
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dimensions = int.Parse(Console.ReadLine());

            var matrix = new int[dimensions, dimensions];
            var firstDiagonal = 0;
            var secondDiagonal = 0;

            for (int row = 0; row < dimensions; row++)
            {
                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < dimensions; col++)
                {
                    matrix[col, row] = currentRow[col];
                    if (row == col)
                    {
                        firstDiagonal += currentRow[col];
                    }
                }
            }

            for (int i = 0; i < dimensions; i++)
            {
                secondDiagonal += matrix[i, dimensions - i - 1];
            }

            var result = Math.Abs(firstDiagonal - secondDiagonal);
            Console.WriteLine(result);
        }
    }
}
