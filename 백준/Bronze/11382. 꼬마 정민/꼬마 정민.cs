using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            string[] tokens = ReadLine().Split();

            long a = long.Parse(tokens[0]);
            long b = long.Parse(tokens[1]);
            long c = long.Parse(tokens[2]);

            WriteLine(a + b + c);
        }
    }
}