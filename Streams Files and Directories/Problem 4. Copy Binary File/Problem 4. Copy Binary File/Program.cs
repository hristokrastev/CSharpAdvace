using System;
using System.IO;

namespace Problem_4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {

            const int Default_Size = 4096;

            using FileStream reader = new FileStream(@".\copyMe.png", FileMode.Open);

            using FileStream writer = new FileStream(@"..\..\..\copied.png", FileMode.Create);

            var buffer = new byte[Default_Size];

            while (reader.CanRead)
            {
                var bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                {
                    break;
                }

                writer.Write(buffer, 0, bytesRead);
            }

        }
    }
}
