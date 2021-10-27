using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywishes = new List<string>();
            mywishes.Add("new pillow");
            mywishes.Add("box of chocolates");
            mywishes.Add("Tear gas");

            int listlength = mywishes.Count;

            Console.WriteLine($"List length: {listlength}");
            //Console.WriteLine(mywishes[0]);
            //Console.WriteLine(mywishes[1]);
            //Console.WriteLine(mywishes[2]);
            foreach(string wish in mywishes)
            {
                Console.WriteLine($"you wish for: {wish}");
            }
        }
    }
}
