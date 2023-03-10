using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            int first = int.Parse(ReadLine());
            int second = int.Parse(ReadLine());

            if (first < -1000 || first > 1000 || first == 0) return;
            else if (second < -1000 || second > 1000 || second == 0) return;

            if (0 < first && 0 < second) WriteLine(1);
            else if (0 > first && 0 < second) WriteLine(2);
            else if (0 > first && 0 > second) WriteLine(3);
            else if (0 < first && 0 > second) WriteLine(4);
            
        }
    }
}
