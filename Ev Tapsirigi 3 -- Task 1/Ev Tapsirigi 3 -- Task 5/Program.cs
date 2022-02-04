using System;

namespace Ev_Tapsirigi_3____Task_5
{
    internal class Program
    /*verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.*/
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int b = 0;
            int c = 0;
            int d = 0;  

            if (a>=100000 && a< 1000000)
            {
                while (a > 0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    b = (b * 10) + qaliq;
                }

                c = b % 10;
                b=(b-c) / 10;
                
                while (b>0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    d=(d * 10) + qaliq;
                }
                d = (d * 10) + 1;
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("6 Reqemli Deyil");
            }
            
        }
    }
}
