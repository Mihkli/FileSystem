using System;
using System.IO;

namespace ReadingFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples\wishlist";
            string userfile = "wishlist";
            string fullfilepath = $@"{rootpath}\{userfile}.txt";

            string[] datafromfile = File.ReadAllLines(fullfilepath);

            foreach(string line in datafromfile)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            datafromfile[0] = "pink unicorn";

            foreach (string line in datafromfile)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(fullfilepath, datafromfile);
        }
    }
}
