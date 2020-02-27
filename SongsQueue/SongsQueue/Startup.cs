using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Startup
    {
        static void Main(string[] args)
        {
            var inputSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var songsQueue = new Queue<string>(inputSongs);
            while (songsQueue.Count > 0)
            {
                var command = Console.ReadLine().Split().ToArray();

                var songFromCommand = "";

                for (int i = 1; i < command.Length; i++)
                {
                    songFromCommand += command[i] + " ";
                }

                songFromCommand = songFromCommand.Trim();

                switch (command[0])
                {
                    case "Play": songsQueue.Dequeue();
                        break;
                    case "Add":
                        if (songsQueue.Contains(songFromCommand))
                        {
                            Console.WriteLine($"{songFromCommand} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(songFromCommand);
                        }
                        break;
                    case "Show": 
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;
                }
                
            }
            Console.WriteLine("No more songs!");
        }
    }
}
