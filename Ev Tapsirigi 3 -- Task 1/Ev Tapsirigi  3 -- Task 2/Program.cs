using System;

namespace Ev_Tapsirigi__3____Task_2
{
    internal class Program
    /*verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: */
    {
        static void Main(string[] args)
        {
            int a = 198273;
            int b;
            int cem = 0;

            if (a>=100000 && a<1000000)
            {
                while (a>1000)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                }

                while (a>0)
                {
                    b = a % 10;
                    a = (a - b) / 10;
                    cem = cem + b;
                }
                Console.WriteLine(cem);

            }
            else
            {
                Console.WriteLine("6 Reqemli Deyil");
            }
        }
    }
}
