using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            int c = 0;
            int d = b;

            while (b > 0)
            {
                c += b % 10;
                WriteLine(a * c);
                c = 0;
                b = b / 10;
            }
            WriteLine(a * d);
        }
    }
}
