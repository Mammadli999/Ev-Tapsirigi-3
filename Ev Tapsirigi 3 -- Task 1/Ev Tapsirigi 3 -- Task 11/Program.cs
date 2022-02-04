using System;

namespace Ev_Tapsirigi_3____Task_11
{
    internal class Program
    /*8 reqemli ededin reqemlerini iki -iki qruplashdir.
     Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
     Sonra cavabin ozunden onun 18% ni cix; */
    {
        static void Main(string[] args)
        {
            int a = 12345678;
            int b = 0;
            if (a>=10000000 && a<100000000)
            {
                while (a>0)
                {
                    int qaliq = a % 100;
                    a = (a - qaliq) / 100;
                    b = b + qaliq;
                }
                double c = (b * 100) + 99;
                double d = (c / 100) * 18;
                double e = c - d;
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine("8 Reqemli Deyil");
            }

        }
    }
}
