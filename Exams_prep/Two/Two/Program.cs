using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialString = Console.ReadLine();

            var matrixSize = int.Parse(Console.ReadLine());

            var matrix = new char[matrixSize, matrixSize];

            var playerRow = 0;
            var playerCol = 0;
            var isFound = false;

            StringBuilder result = new StringBuilder(initialString);

            for (int row = 0; row < matrixSize; row++)
            {
                char[] currentRow1 = ParseArrayFromConsole();
                for (int col = 0; col < matrixSize; col++)
                {
                    if (!isFound)
                    {
                        if (currentRow1[col] == 'P')
                        {
                            playerRow = row;
                            playerCol = col;
                            isFound = true;
                        }
                    }
                    
                    matrix[row, col] = currentRow1[col];
                }

            }


            var currentRow = 0;
            var currentCol = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {

                    switch (command)
                    {
                        case "up":
                            currentRow = playerRow;
                            playerRow = playerRow - 1;
                            if (playerRow > (matrix.GetLength(0) - 1) || playerRow < 0)
                            {
                                playerRow = playerRow + 1;
                                if (result.Length > 0)
                                {
                                    result.Remove(result.Length - 1, 1);
                                }
                                matrix[playerRow, playerCol] = 'P';
                                break;
                            }
                            if (char.IsLetter(matrix[playerRow, playerCol]))
                            {
                                result.Append(matrix[playerRow, playerCol]);
                                matrix[currentRow, playerCol] = '-';
                                matrix[playerRow, playerCol] = 'P';
                            }
                            else
                            {
                            matrix[currentRow, playerCol] = '-';
                            matrix[playerRow, playerCol] = 'P';
                                
                            }
                            break;
                        case "down":
                            currentRow = playerRow;
                            playerRow = playerRow + 1;
                            if (playerRow > (matrix.GetLength(0) - 1) || playerRow < 0)
                            {
                                playerRow = playerRow - 1;
                                if (result.Length > 0)
                                {
                                    result.Remove(result.Length - 1, 1);
                                }
                                matrix[playerRow, playerCol] = 'P';
                                break;
                            }
                            if (char.IsLetter(matrix[playerRow, playerCol]))
                            {
                                result.Append(matrix[playerRow, playerCol]);
                                matrix[currentRow, playerCol] = '-';
                                matrix[playerRow, playerCol] = 'P';
                            }
                            else
                            {
                                matrix[playerRow, playerCol] = 'P';
                                matrix[currentRow, playerCol] = '-';
                            }
                            break;
                        case "left":
                            currentCol = playerCol;
                            playerCol = playerCol - 1;
                            if (playerCol > (matrix.GetLength(1) - 1 )|| playerCol < 0)
                            {
                                playerCol = playerCol + 1;
                                if (result.Length > 0)
                                {
                                    result.Remove(result.Length - 1, 1);
                                }
                                matrix[playerRow, playerCol] = 'P';
                                break;
                            }
                            if (char.IsLetter(matrix[playerRow, playerCol]))
                            {
                                result.Append(matrix[playerRow, playerCol]);
                                matrix[playerRow, currentCol] = '-';
                                matrix[playerRow, playerCol] = 'P';
                            }
                            else
                            {
                                matrix[playerRow, playerCol] = 'P';
                                matrix[playerRow, currentCol] = '-';
                            }
                            break;
                        case "right":
                            currentCol = playerCol;
                            playerCol = playerCol + 1;
                            if (playerCol > (matrix.GetLength(1) - 1) || playerCol < 0)
                            {
                                playerCol = playerCol - 1;
                                if (result.Length > 0)
                                {
                                    result.Remove(result.Length - 1, 1);
                                }
                                matrix[playerRow, playerCol] = 'P';
                                break;
                            }
                            if (char.IsLetter(matrix[playerRow, playerCol]))
                            {
                                result.Append(matrix[playerRow, playerCol]);
                                matrix[playerRow, currentCol] = '-';
                                matrix[playerRow, playerCol] = 'P';
                            }
                            else
                            {
                                
                                matrix[playerRow, currentCol] = '-';
                            matrix[playerRow, playerCol] = 'P';
                        }
                            break;
                        default:
                            break;


                    }

               
            }

            Console.WriteLine(result);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static char[] ParseArrayFromConsole()
        {
            return Console.ReadLine().ToCharArray();
        }
    }
}
