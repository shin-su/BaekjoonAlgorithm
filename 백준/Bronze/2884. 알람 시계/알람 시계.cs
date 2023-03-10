using System;
using static System.Console;

namespace Baekjoon
{
    class Algorithm
    {
        static void Main(string[] args)
        {
            string[] time = ReadLine().Split();
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            if (hour < -1 || hour > 23) return;
            else if (minute < -1 || minute > 59) return;

            minute -= 45;
            if (minute < 0)
            {
                hour--;
                minute = 60 + minute;

                if (hour < 0) hour = 23;
                if (minute == 60) minute = 0;
            }
            WriteLine(hour.ToString() + " " + minute.ToString());
        }
    } 
}
