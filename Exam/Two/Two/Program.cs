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
            var n = int.Parse(Console.ReadLine());

            var countOfCommands = int.Parse(Console.ReadLine());

            //var initialString = Console.ReadLine();

            var matrix = new char[n, n];

            var playerRow = 0;
            var playerCol = 0;
            var isFoundPlayer = false;

            var finishRow = 0;
            var finishCol = 0;
            var isFoundFinish = false;




            for (int row = 0; row < n; row++)
            {
                char[] currentRow1 = ParseArrayFromConsole();
                for (int col = 0; col < n; col++)
                {
                    if (!isFoundPlayer)
                    {
                        if (currentRow1[col] == 'f')
                        {
                            playerRow = row;
                            playerCol = col;
                            isFoundPlayer = true;
                        }
                    }


                    matrix[row, col] = currentRow1[col];
                }

            }


            var currentRow = 0;
            var currentCol = 0;

            var commandCounter = countOfCommands;

            for (int com = 0; com < countOfCommands; com++)
            {

                if (isFoundFinish)
                {
                    break;
                }



                string command = Console.ReadLine();


                commandCounter--;
                switch (command)
                {
                    case "up":
                        currentRow = playerRow;
                        playerRow = playerRow - 1;
                        if (playerRow > (matrix.GetLength(0) - 1) || playerRow < 0)
                        {
                            if (playerRow < 0)
                            {
                                playerRow = matrix.GetLength(0) - 1;
                            }
                            else
                            {
                                if (playerRow < 0)
                                {
                                    playerRow = matrix.GetLength(0) - 1;
                                }
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    isFoundFinish = true;
                                    Console.WriteLine("Player won!");
                                    matrix[currentRow, playerCol] = '-';


                                }
                                else if (matrix[playerRow, playerCol] == 'B')
                                {
                                    playerRow = playerRow + 1;
                                }
                                else if (matrix[playerRow, playerCol] == 'T')
                                {
                                    playerRow = playerRow - 1;
                                }

                            }


                            matrix[playerRow, playerCol] = 'f';
                            matrix[currentRow, playerCol] = '-';
                            break;
                        }
                        else
                        {

                            if (playerRow < 0)
                            {
                                playerRow = matrix.GetLength(0) - 1;
                            }
                            else
                            {
                                if (playerRow < 0)
                                {
                                    playerRow = matrix.GetLength(0) - 1;
                                }
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    isFoundFinish = true;
                                    Console.WriteLine("Player won!");
                                    matrix[currentRow, playerCol] = '-';


                                }
                                else if (matrix[playerRow, playerCol] == 'B')
                                {
                                    playerRow = playerRow + 1;
                                }
                                else if (matrix[playerRow, playerCol] == 'T')
                                {
                                    playerRow = playerRow - 1;
                                }
                            }


                            //if (playerRow < 0)
                            //{

                            //}
                            matrix[playerRow, playerCol] = 'f';
                            matrix[currentRow, playerCol] = '-';
                            break;
                        }
                    case "down":
                        currentRow = playerRow;
                        playerRow = playerRow + 1;
                        if (playerRow > (matrix.GetLength(0) - 1) || playerRow < 0)
                        {
                            if (playerRow > (matrix.GetLength(0) - 1))
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                if (playerRow > (matrix.GetLength(0) - 1))
                                {
                                    playerRow = 0;
                                }
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    isFoundFinish = true;
                                    Console.WriteLine("Player won!");
                                    matrix[currentRow, playerCol] = '-';


                                }
                                else if (matrix[playerRow, playerCol] == 'B')
                                {
                                    playerRow = playerRow + 1;
                                }
                                else if (matrix[playerRow, playerCol] == 'T')
                                {
                                    playerRow = playerRow - 1;
                                }
                            }


                            matrix[playerRow, playerCol] = 'f';
                            matrix[currentRow, playerCol] = '-';
                            break;
                        }
                        else
                        {

                            if (playerRow > (matrix.GetLength(0) - 1))
                            {
                                playerRow = 0;
                            }
                            else
                            {
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    isFoundFinish = true;
                                    Console.WriteLine("Player won!");
                                    matrix[currentRow, playerCol] = '-';


                                }
                                else if (matrix[playerRow, playerCol] == 'B')
                                {
                                    playerRow = playerRow + 1;
                                }
                                else if (matrix[playerRow, playerCol] == 'T')
                                {
                                    playerRow = playerRow - 1;
                                }

                            }

                            if (playerCol < 0)
                            {
                                playerRow = playerRow + 1;
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            matrix[playerRow, playerCol] = 'f';
                            matrix[currentRow, playerCol] = '-';
                            break;
                        }

                    case "left":
                        currentCol = playerCol;
                        playerCol = playerCol - 1;
                        if (playerCol > (matrix.GetLength(1) - 1) || playerCol < 0)
                        {

                            if (playerCol < 0)
                            {
                                playerRow = playerRow + 1;
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            else
                            {
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    isFoundFinish = true;
                                    Console.WriteLine("Player won!");
                                    matrix[playerRow, currentCol] = '-';


                                }
                                else if (matrix[playerRow, playerCol] == 'B')
                                {
                                    playerCol = playerCol - 1;
                                }
                                else if (matrix[playerRow, playerCol] == 'T')
                                {
                                    playerCol = playerCol + 1;
                                }
                            }

                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                isFoundFinish = true;
                                Console.WriteLine("Player won!");
                            }

                                matrix[playerRow, playerCol] = 'f';
                            matrix[playerRow, currentCol] = '-';
                            break;


                        }
                        else
                        {
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                isFoundFinish = true;
                                Console.WriteLine("Player won!");
                                matrix[playerRow, currentCol] = '-';


                            }
                            else if (matrix[playerRow, playerCol] == 'B')
                            {
                                playerCol = playerCol - 1;
                            }
                            else if (matrix[playerRow, playerCol] == 'T')
                            {
                                playerCol = playerCol + 1;
                            }
                            if (playerCol < 0)
                            {

                                playerRow = playerRow + 1;
                                playerCol = matrix.GetLength(1) - 1;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                isFoundFinish = true;
                                Console.WriteLine("Player won!");
                            }
                            matrix[playerRow, playerCol] = 'f';
                            matrix[playerRow, currentCol] = '-';
                            break;
                        }

                    case "right":
                        currentCol = playerCol;
                        playerCol = playerCol + 1;
                        if (playerCol > (matrix.GetLength(1) - 1) || playerCol < 0)
                        {
                            if (playerCol > (matrix.GetLength(1) - 1))
                            {
                                playerRow = playerRow + 1;
                                playerCol = 0;
                            }
                            else
                            {
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    isFoundFinish = true;
                                    Console.WriteLine("Player won!");
                                    matrix[playerRow, currentCol] = '-';


                                }
                                else if (matrix[playerRow, playerCol] == 'B')
                                {
                                    playerCol = playerCol + 1;
                                }
                                else if (matrix[playerRow, playerCol] == 'T')
                                {
                                    playerCol = playerCol - 1;
                                }
                            }

                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                isFoundFinish = true;
                                Console.WriteLine("Player won!");
                            }
                                matrix[playerRow, playerCol] = 'f';
                            matrix[playerRow, currentCol] = '-';
                            break;

                        }
                        else
                        {
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                isFoundFinish = true;
                                Console.WriteLine("Player won!");
                                matrix[currentRow, playerCol] = '-';


                            }
                            else if (matrix[playerRow, playerCol] == 'B')
                            {
                                playerCol = playerCol + 1;
                            }
                            else if (matrix[playerRow, playerCol] == 'T')
                            {
                                playerCol = playerCol - 1;
                            }
                            if (matrix[playerRow, playerCol] == 'F')
                            {
                                isFoundFinish = true;
                                Console.WriteLine("Player won!");
                            }
                                matrix[playerRow, playerCol] = 'f';
                            matrix[playerRow, currentCol] = '-';
                            break;
                        }
                        
                    default:
                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            isFoundFinish = true;
                            Console.WriteLine("Player won!");
                        }
                        break;


                }

                if (com == countOfCommands - 1 && isFoundFinish == false)
                {
                    Console.WriteLine("Player lost!");
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

        public static char[] ParseArrayFromConsole()
        {
            return Console.ReadLine().ToCharArray();
        }
    }

}
