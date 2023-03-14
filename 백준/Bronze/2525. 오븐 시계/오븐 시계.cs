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

            int inputTime = int.Parse(ReadLine());

            if (hour < -1 || hour > 23) return;
            else if (minute < -1 || minute > 59) return;
            else if (inputTime < -1 || inputTime > 1000) return;

            minute += inputTime;
            
            while(minute >= 60)
            {
                hour++;
                minute = minute - 60;
                if (hour == 24) hour = 0;

                if (minute < 60)
                {
                    break;
                }
            }
            WriteLine(hour.ToString() + " " + minute.ToString());
        }
    } 
}
