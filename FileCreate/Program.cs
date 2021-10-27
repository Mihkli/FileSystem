using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples\wishlist";
            string userfile = "wishlist";
            string fullfilepath = $@"{rootpath}\{userfile}.txt";

            bool directoryexists = Directory.Exists(rootpath);
            bool fileExists = File.Exists(fullfilepath);

            if (directoryexists && fileExists)
            {
                Console.WriteLine($"{userfile} Already exists in {rootpath}.");
            }
            else if (!directoryexists)
            {
                Console.WriteLine($"{rootpath} Does not exist");
                Directory.CreateDirectory(rootpath);
                Console.WriteLine($"{rootpath} has been created.");
                File.Create(fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootpath}.");
            }
            else
            {
                File.Create(fullfilepath);
                Console.WriteLine($"{userfile}.txt has been created in {rootpath}.");
            }

            
         
        }
    }
}
