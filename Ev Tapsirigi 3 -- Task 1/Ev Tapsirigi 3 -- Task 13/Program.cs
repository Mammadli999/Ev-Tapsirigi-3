using System;

namespace Ev_Tapsirigi_3____Task_13
{
    internal class Program
    /*3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.*/
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 54321;
            int c = 44444;
            int e = 0;
            int f = 0;
            int g = 0;


            bool aa = (a >= 10000 && b >= 10000 && c >= 10000);
            bool bb = (a < 100000 && b < 100000 && c < 100000);
            if (aa == bb)
            {
                int d = a % 10;

                while (a>0)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    e = (e * 10) + qaliq;
                }
                e = e % 10;
                e = (e * 10) + d;

                int l = b % 10;
                while (b>0)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                    f=(f* 10) + qaliq;
                }
                f=f % 10;
                f = (f * 10) + l;

                int k = c % 10;
                while (c>0)
                {
                    int qaliq = c % 10;
                    c = (c - qaliq) / 10;
                    g = (g * 10) + qaliq;
                }
                g=g % 10;
                g=(g*10) + k;

                int m = e + f + g;
                double h = (m / 100) * 50;
                double s = m + h;

                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("5 Reqemli Deyil");
            }
        }
    }
}
