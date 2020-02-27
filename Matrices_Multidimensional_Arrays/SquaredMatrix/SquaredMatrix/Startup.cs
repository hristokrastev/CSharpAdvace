using System;
using System.Linq;

namespace SquaredMatrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var totalRows = dimensions[0];

            var totalCols = dimensions[1];

            var matrix = new char[totalRows, totalCols];

            var squares = 0;

            for (int row = 0; row < totalRows; row++)
            {
                var currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < totalCols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row + 1, col] == matrix[row + 1, col +1]
                        && matrix[row + 1, col + 1] == matrix[row, col])
                    {
                        squares++;
                    }
                }
            }
            Console.WriteLine(squares);
        }
    }
}
