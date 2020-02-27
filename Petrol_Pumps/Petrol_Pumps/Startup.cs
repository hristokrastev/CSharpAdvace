using System;
using System.Collections.Generic;
using System.Linq;

namespace Petrol_Pumps
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numberOfPumps = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            var count = 0;

            FillQueue(numberOfPumps, pumps);

            while (true)
            {
                var fuelAmount = 0;
                var foundPoint = true;

                for (int i = 0; i < numberOfPumps; i++)
                {
                    var currentPump = pumps.Dequeue();
                    fuelAmount += currentPump[0];

                    if (fuelAmount < currentPump[1])
                    {
                        foundPoint = false;
                    }

                    fuelAmount -= currentPump[1];

                    pumps.Enqueue(currentPump);
                }

                if (foundPoint)
                {
                    break;
                }
                count++;

                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(count);
        }

        private static void FillQueue(int numberOfPumps, Queue<int[]> pumps)
        {
            for (int i = 0; i < numberOfPumps; i++)
            {
                var currPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(currPump);

            }
        }
    }
}
