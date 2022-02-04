using System;

namespace Ev_Tapsirigi_3____Task_10
{
    internal class Program
    /*9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
     sonra cut yerde dayanlarinda bir eded duzlet,
     sonra onlari topla*/
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int a1 = a;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int counter1 = 1;
            int counter2 = 0;


            if (a>=100000000 && a<1000000000)
            {
                while (a>0)
                {
                    int qaliq = a % 10;
                    a = a / 10;
                    if (counter1 % 2 != 0)
                    {
                        b = (b * 10) + qaliq;
                    }
                    counter1++;
                }
                while (b > 0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    c = (c * 10) + qaliq;
                }
                while (a1>0)
                {
                    int qaliq = a1 % 10;
                    a1 = a1 / 10;
                    if (counter2 % 2 != 0)
                    {
                        d = (d * 10) + qaliq;
                    }
                    counter2++;
                }
                while (d>0)
                {
                    int qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    e = (e * 10) + qaliq;
                }

                int i = c + e;
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("9 Reqemli Deyil");
            }

        }
    }
}
