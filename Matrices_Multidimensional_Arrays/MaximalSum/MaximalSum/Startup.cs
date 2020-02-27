using System;
using System.Linq;

namespace MaximalSum
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

           var totalRows = dimensions[0];
           var totalCols = dimensions[1];

            var qubeArray = new int[totalRows, totalCols];

            var maxSum = int.MinValue;
            var maxSumRow = 0;
            var maxSumCol = 0;

            for (int row = 0; row < qubeArray.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < qubeArray.GetLength(1); col++)
                {
                    qubeArray[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < totalRows - 2; row++)
            {
                for (int col = 0; col < totalCols - 2; col++)
                {
                    var currentSum = qubeArray[row, col] + qubeArray[row, col + 1] + qubeArray[row, col + 2]
                        + qubeArray[row + 1, col] + qubeArray[row + 1, col + 1] + qubeArray[row + 1, col + 2]
                        + qubeArray[row + 2, col] + qubeArray[row + 2, col + 1] + qubeArray[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{qubeArray[maxSumRow, maxSumCol]} {qubeArray[maxSumRow, maxSumCol + 1]} {qubeArray[maxSumRow, maxSumCol + 2]}");
            Console.WriteLine($"{qubeArray[maxSumRow + 1, maxSumCol]} {qubeArray[maxSumRow + 1, maxSumCol + 1]} {qubeArray[maxSumRow + 1, maxSumCol + 2]}");
            Console.WriteLine($"{qubeArray[maxSumRow + 2, maxSumCol]} {qubeArray[maxSumRow + 2, maxSumCol + 1]} {qubeArray[maxSumRow + 2, maxSumCol + 2]}");
        }
    }
}
