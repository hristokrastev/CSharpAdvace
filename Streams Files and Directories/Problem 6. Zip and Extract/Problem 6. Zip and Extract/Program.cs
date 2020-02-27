using System;
using System.IO.Compression;

namespace Problem_6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\SoftUni\C#Advanced_SoftUni\Streams Files and Directories\Problem 6. Zip and Extract\Problem 6. Zip and Extract\folderForArchive",
                @"..\..\..\MyDestinationArchive.zip");

            ZipFile.ExtractToDirectory(@"C:\SoftUni\C#Advanced_SoftUni\Streams Files and Directories\Problem 6. Zip and Extract\Problem 6. Zip and Extract\MyDestinationArchive.zip",
                @"..\..\..\");
        }
    }
}
