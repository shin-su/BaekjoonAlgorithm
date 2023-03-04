using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] b = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(b[0]) * int.Parse(b[1]));
        }
    }
}