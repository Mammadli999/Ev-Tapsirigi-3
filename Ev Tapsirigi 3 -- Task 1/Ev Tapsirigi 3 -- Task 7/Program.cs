using System;

namespace Ev_Tapsirigi_3____Task_7
{
    internal class Program
    /*verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir*/
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int qaliq;
            int b=0;
            int c;
            int d;
            if (a>=1000 && a<10000)
            {
                while (a > 0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    b = (b * 10) + qaliq;
                }

                c = (10 * b) + 8;
                d = 800000 + c;
                Console.WriteLine(d);

            }
            else
            {
                Console.WriteLine("9 Reqemli Deyil");
            }
        }
    }
}
