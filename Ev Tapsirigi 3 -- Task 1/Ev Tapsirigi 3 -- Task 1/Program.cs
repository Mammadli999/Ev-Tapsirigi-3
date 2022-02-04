using System;

namespace Ev_Tapsirigi_3____Task_1
{
    internal class Program
    /*verilmish 4 reqemli ededin reqemlerinin cemini tap
     */
    {
        static void Main(string[] args)
        {
            int a = 2071;
            int cem = 0;

            if (a>=1000 && a<10000)
            {
                while (a>0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;

                    cem = cem + qaliq;
                }

                Console.WriteLine(cem);

            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}
