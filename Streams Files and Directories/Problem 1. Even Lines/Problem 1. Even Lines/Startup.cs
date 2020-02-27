using System;
using System.IO;
using System.Linq;

namespace Problem_1._Even_Lines
{
    class Startup
    {
        static void Main(string[] args)
        {
            using var streamReader = new StreamReader(@"text.txt");
             
            int lineCounter = 0;

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();

                if (line == null)
                {
                    break;
                }
                
                if (lineCounter % 2 == 0)
                {
                    line = ReplaceSymbols(line);

                    line = string.Join(' ', line.Split(' ').Reverse());

                    Console.WriteLine(line);
                }

                lineCounter++;
            }

            

        }

        private static string ReplaceSymbols(string line)
        {
            line = line.Replace('-', '@');
            line = line.Replace(',', '@');
            line = line.Replace('.', '@');
            line = line.Replace('!', '@');
            line = line.Replace('?', '@');
            return line;
        }
    }
}
