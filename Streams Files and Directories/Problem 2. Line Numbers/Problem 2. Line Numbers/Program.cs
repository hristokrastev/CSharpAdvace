using System;
using System.IO;
using System.Linq;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = File.ReadAllLines(@"text.txt");

            var letterCount = 0;

            var punctuationCount = 0;

            var result = new string[output.Length];

            for (int i = 0; i < output.Length; i++)
            {
                var currentLine = output[i];
                for (int j = 0; j < output[i].Length; j++)
                {
                    char currentSymbol = currentLine[j];
                    if (char.IsLetter(currentSymbol))
                    {
                        letterCount++;
                    }
                    else if (char.IsPunctuation(currentSymbol))
                    {
                        punctuationCount++;

                    }
                }

                result[i] = ($"Line {i + 1}: {output[i]}({letterCount})({punctuationCount})");
                letterCount = 0;
                punctuationCount = 0;

            }
            

            File.WriteAllLines(@"..\..\..\result.txt", result);
        }
    }
}
