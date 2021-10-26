using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootpath = @"C:\Users\opilane\samples";

            Console.WriteLine("Enter directory name:");
            string userfolder = Console.ReadLine();

            string newdirectoryfullpath = @$"{rootpath}\{userfolder}";
            bool directoryexists = Directory.Exists(newdirectoryfullpath);

            if(directoryexists)
            {
                Console.WriteLine($"{userfolder} exists.");
                Console.WriteLine("Would you like to create a folder Y/N?");
                char userinput = Convert.ToChar(Console.ReadLine());

                if(userinput == 'y')
                {
                    Console.WriteLine("Enter file name:");
                    string userfile = Console.ReadLine() + ".txt";
                    string userfilefullpath = $@"{newdirectoryfullpath}\{userfile}";
                    File.Create(userfilefullpath);
                }
                else
                {
                    Console.WriteLine("Norm kõrvik oled.");
                }

            } 
            else
            {
                Directory.CreateDirectory(newdirectoryfullpath);
                Console.WriteLine($"Directory {userfolder} has been created.");
            }
                   

        }
    }
}
