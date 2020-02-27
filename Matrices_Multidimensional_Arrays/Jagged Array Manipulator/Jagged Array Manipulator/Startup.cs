using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Startup
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var array = new double[rows][];

            for (int fillArray = 0; fillArray < rows; fillArray++)
            {
                var currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();

                array[fillArray] = currentRow;

                if (fillArray > 0 && fillArray < rows)
                {
                    if (array[fillArray].Length == array[fillArray - 1].Length)
                    {
                        var doubledArray = Array.ConvertAll(array[fillArray], x => x * 2);
                        array[fillArray] = doubledArray;
                        var doubledArray2 = Array.ConvertAll(array[fillArray - 1], x => x * 2);
                        array[fillArray - 1] = doubledArray2;

                    }
                    else
                    {
                        var doubledArray = Array.ConvertAll(array[fillArray], x => x / 2);
                        array[fillArray] = doubledArray;
                        var doubledArray2 = Array.ConvertAll(array[fillArray - 1], x => x / 2);
                        array[fillArray - 1] = doubledArray2;
                    }
                }

                
            }

            while (true)
            {
                var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var operation = command[0];
                if (operation == "End")
                {
                    break;
                }
                var row = int.TryParse(command[1], out int rowResult);
                var col = int.TryParse(command[2], out int colResult);
                var value = int.TryParse(command[3], out int resValue);

                switch (operation)
                {
                    case "Add":
                        try
                        {
                            array[rowResult][colResult] += resValue;
                        }
                        catch (Exception ex)
                        {
                            
                            continue;
                        }
                        break;
                    case "Subtract":
                        try
                        {
                            array[rowResult][colResult] -= resValue;
                        }
                        catch (Exception ex)
                        {
                            
                            continue;
                        }
                        break;

                    default:
                        break;
                }

            }

            foreach (var currentRow in array)
            {
                Console.WriteLine(string.Join(' ', currentRow));
            }
        }
    }
}
