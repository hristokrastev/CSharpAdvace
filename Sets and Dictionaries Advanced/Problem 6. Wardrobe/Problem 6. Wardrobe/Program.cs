using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLinesOfClothes = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLinesOfClothes; i++)
            {
                var inTheWardrobe = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var color = inTheWardrobe[0];
                var clothes = inTheWardrobe[1];

                var cloth = inTheWardrobe[1].Split(',', StringSplitOptions.RemoveEmptyEntries);


                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var clo in cloth)
                {
                    if (!wardrobe[color].ContainsKey(clo))
                    {
                        wardrobe[color][clo] = 0;
                    }
                    wardrobe[color][clo]++;
                }
            }
            var lookingFor = Console.ReadLine().Split();
            var colorToLookFor = lookingFor[0];
            var clothToLookFor = lookingFor[1];

            foreach (var cdp in wardrobe)
            {
                string color = cdp.Key;
                Dictionary<string,int> cloth = cdp.Value;

                Console.WriteLine($"{color} clothes:");
                foreach (var cqp in cloth)
                {
                    string c = cqp.Key;
                    int qnty = cqp.Value;

                    
                    if (colorToLookFor == color && clothToLookFor == c)
                    {
                        Console.WriteLine($"* {c} - {qnty} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {c} - {qnty}");
                    }
                }
            }

        }
    }
}
