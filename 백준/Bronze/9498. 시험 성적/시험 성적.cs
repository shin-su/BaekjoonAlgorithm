using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            int score = int.Parse(ReadLine());

            if (score > 100 || score < 0) return;
            
            if(89 < score) WriteLine("A");
            else if(79 < score) WriteLine("B");
            else if(69 < score) WriteLine("C");
            else if(59 < score) WriteLine("D");
            else if(59 >= score) WriteLine("F");
        }
    }
}
