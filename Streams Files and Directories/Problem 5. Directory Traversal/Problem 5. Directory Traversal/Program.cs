using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var files = Directory.GetFiles(input);

            var fileSize = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                var filesInfo = new FileInfo(file);
                if (!fileSize.ContainsKey(filesInfo.Extension))
                {
                    fileSize.Add(filesInfo.Extension, new Dictionary<string, double>());
                }
                

            }
            foreach (var file in files)
            {

                var filesInfo = new FileInfo(file);

                if (fileSize.ContainsKey(filesInfo.Extension))
                {
                    fileSize[filesInfo.Extension].Add(filesInfo.Name, (double)filesInfo.Length / 1024);
                }
            }



            fileSize = fileSize
                .OrderByDescending(x => x.Value.Values.Count)
                .ToDictionary(x => x.Key, x => x.Value.OrderByDescending(y => y.Value)
                .ToDictionary(y => y.Key, y => y.Value));

            //File.Create($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\result.txt");
            foreach (var (extension, dict) in fileSize)
            {

               File.AppendAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\result.txt", extension + Environment.NewLine);
                foreach (var (key, value) in dict)
                {
                    File.AppendAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)}\\result.txt", ($"--{key} - {value:F3}kb") + Environment.NewLine);
                }
            }

        }
    }
}
