using System;

namespace Ev_Tapsirigi_3____Task_4
{
    internal class Program
    /*verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati*/
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b;
            int c;

            if (a >= 10000 && a < 100000)
            {
                b = a % 10;
                a = a / 10000;

                c = a + b;
                c = c * c;
                Console.WriteLine(c);

            }
            else
            {
                Console.WriteLine("5 Reqemli Deyil");
            }
        }
    }
}
