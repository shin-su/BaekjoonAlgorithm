using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            int year = int.Parse(ReadLine());

            if (year < 1 || year > 4000) return;

            if (year % 4 == 0 && year % 100 != 0)
            {
                WriteLine(1);
            }
            else if (year % 400 == 0)
            {
                WriteLine(1);
            }
            else
            {
                WriteLine(0);
            }
        }
    }
}
