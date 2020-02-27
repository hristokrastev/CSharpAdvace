using System;
using System.Linq;

namespace MatrixShuffling
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var rows = dimensions[0];

            var cols = dimensions[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            while (true)
            {
                var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                

                if (commands[0] == "END")
                {
                    break;
                }
                else if(commands.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if(commands[0] == "swap")
                {
                    if (int.Parse(commands[1]) > matrix.GetLength(0) || int.Parse(commands[2]) > matrix.GetLength(1)
                        || int.Parse(commands[3]) > matrix.GetLength(0) || int.Parse(commands[4]) > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    var row1 = int.Parse(commands[1]);
                    var col1 = int.Parse(commands[2]);

                    var row2 = int.Parse(commands[3]);
                    var col2 = int.Parse(commands[4]);


                        var historySwap = matrix[row1, col1];
                        var history = matrix[row2, col2];

                        matrix[row1, col1] = history;
                        matrix[row2, col2] = historySwap;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                
            }
        }
    }
}
