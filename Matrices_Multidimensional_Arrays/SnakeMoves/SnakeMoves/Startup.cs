using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMoves
{
    class Startup
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();

            var rows = dimensions[0];

            var cols = dimensions[1];

            var snakeName = Console.ReadLine();

            var queue = new Queue<char>(snakeName);

            var matrix = new char[rows, cols];


                
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                
                if (row %2 == 0)
                {
                    for (int i = 0; i < cols; i++)
                    {
                        if (queue.Count == 0)
                        {
                            queue = new Queue<char>(snakeName);
                        }
                        matrix[row, i] = queue.Dequeue();
                    }

                }else if(row % 2 != 0)
                {
                    for (int j = cols - 1; j > -1; j--)
                    {
                        if (queue.Count == 0)
                        {
                            queue = new Queue<char>(snakeName);
                        }
                        matrix[row, j] = queue.Dequeue();
                    }
                }
                    
                }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    Console.Write(matrix[row, col]);

                    
                }
                Console.WriteLine();
            }



        }
    }
}
