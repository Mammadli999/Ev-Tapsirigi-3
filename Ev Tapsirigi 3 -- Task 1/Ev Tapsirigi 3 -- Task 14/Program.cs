using System;

namespace Ev_Tapsirigi_3____Task_14
{
    internal class Program
    /*4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
    6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
    Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
    Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
    Neticenin 60 % tap. Cavabin axirina 60 artir.
    Neticeden 18% cix.*/
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 1234567;
            int d1 = a;
            int d2 = 1;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;

            bool aa = (a >= 100000 && b >= 100000 && c >= 100000 && d >= 1000000);
            bool bb = (a < 1000000 && b < 1000000 && c < 1000000 && d < 10000000);
            if (aa == bb)
            {
                while (a>1000)
                {
                    int qaliq = a % 10;
                    a = (a - qaliq) / 10;
                }
                while (b>1000)
                {
                    int qaliq = b % 10;
                    b = (b - qaliq) / 10;
                }
                while (c > 1000)
                {
                    int qaliq = c % 10;
                    c = (c - qaliq) / 10;
                }

                int a1 = a + b + c;
                

                while (d > 1000)
                {
                    int qaliq = d % 10;
                    d = (d - qaliq) / 10;
                    e = (e * 10) + qaliq;
                }
                while (e>0)
                {
                    int qaliq = e % 10;
                    e = (e - qaliq) / 10;
                    f = (f * 10) + qaliq;
                }
                int a2 = a1 + f;

                while (d1>1000)
                {
                    int qaliq = d1 % 10;
                    d1 = (d1 - qaliq) / 10;
                }
                while (d1>0)
                {
                    int qaliq = d1 % 10;
                    d1 = (d1 - qaliq) / 10;
                    d2 = d2 * qaliq;
                }

                int b1 = a2 - d2;

                double s = (b1 / 100) * 60;
                double m = (s * 100) + 60;
                double l = (m / 100) * 18;
                double r = m - l;

                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
        }
    }
}
