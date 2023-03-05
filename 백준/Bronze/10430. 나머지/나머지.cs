using System;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            string[] val = Console.ReadLine().Split();
            int a = int.Parse(val[0]);
            int b = int.Parse(val[1]);
            int c = int.Parse(val[2]);

            Console.WriteLine((a+b)%c);
            Console.WriteLine(((a%c)+(b%c))%c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
