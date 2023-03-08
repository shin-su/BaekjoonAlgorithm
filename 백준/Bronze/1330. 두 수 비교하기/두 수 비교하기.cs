using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            string[] a = ReadLine().Split();
            int b = int.Parse(a[0]);
            int c = int.Parse(a[1]);
            if(b < c)
            {
                WriteLine("<");
            }
            else if(b > c)
            {
                WriteLine(">");
            }
            else if(b == c)
            {
                WriteLine("==");
            }
        }
    }
}
