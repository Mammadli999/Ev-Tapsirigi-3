using System;

namespace Ev_Tapsirigi_3____Task_6
{
    internal class Program
        /*verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et*/
    {
        static void Main(string[] args)
        {
            int a = 12345678;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;

            if (a>=10000000 && a<100000000)
            {
                while (a > 0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    b = (b * 10) + qaliq;
                }

                c = b % 10;
                b = (b - c) / 10;

                while (b>0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    d = (d * 10) + qaliq;
                }
                
                e = d % 10;
                d = (d - e) / 10;

                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("8 Reqemli Deyil");
            }
        }
    }
}
