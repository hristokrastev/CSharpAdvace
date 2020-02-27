using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"text.txt")
                .Split(new char[] { ' ', '-', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToArray();

            var words = File.ReadAllLines(@"words.txt");

            var containsCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                containsCount.Add(words[i], 0);
            }


                for (int j = 0; j < text.Length; j++)
                {
                    if (containsCount.ContainsKey(text[j]))
                    {
                        try
                        {
                            containsCount[text[j]]++;
                        }
                        catch (Exception ex)
                        {

                            continue;
                        }

                    }
                }

            var actualResult = new string[containsCount.Count];
            var index = 0;
            foreach (var (key, value) in containsCount)
            {
                actualResult[index] = $"{key} - {value}";
                index++;
            }

            var expectedResult = new string[containsCount.Count];

            var items = from KeyValuePair in containsCount orderby KeyValuePair.Value descending select KeyValuePair;

            var help = 0;
            foreach (KeyValuePair<string, int> pair in items)
            {
                expectedResult[help] = $"{pair.Key} - {pair.Value}";
                help++;
            }

            File.WriteAllLines(@"..\..\..\actualResult.txt", actualResult);

            File.WriteAllLines(@"..\..\..\expectedResult.txt", expectedResult);
        }
    }
}
