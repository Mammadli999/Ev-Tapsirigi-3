using System;

namespace Ev_Tapsirigi_3____Task_12
{
    internal class Program
    /*2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne
    II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axrinci reqemini artir.*/
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 54321;
            int a3 = a;
            int c = 0;
            int d = 1;

            bool aa = (a >= 10000 && b >= 10000);
            bool bb = (a < 100000 && b < 100000);
            if (aa == bb)
            {
                while (a>0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    c = c + qaliq;
                }
                while (b > 0) 
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    d = d * qaliq;
                }

                int e = c + d;
                int f = a3 % 10;
                int g = (e * 10) + f;
                Console.WriteLine(g);
            }
            else
            {
                Console.WriteLine("5 Reqemli Deyil");
            }
        }
    }
}
