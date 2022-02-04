using System;

namespace Ev_Tapsirigi_3____Task_15
{
    internal class Program
    /*5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
    3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
    Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
    Cavabdan 7 reqemli ededin son 5 reqemini cix.
    Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
    Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
    Cavabin axirina 11 artir.
    Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
    Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 234;
            int c = 123456;
            int d = 234567;
            int e = 1234567;
            int e1 = e;
            int e2 = e;
            int m = 0;
            int n = 0;
            int w = 0;
            int r = 0;
            int t = 0;
            int t1 = 0;
            int t2= 0;
            int counter = 1;
            

            bool aa = (a >= 100 && b >= 100 && c >= 100000 && d >= 100000 && e >= 1000000);
            bool bb = (a < 1000 && b < 1000 && c < 1000000 && d < 1000000 && e < 10000000);
            if (aa==bb)
            {
                int f = a + b;
                f = f % 100;
                f = f * f;

                int l = (a * 1000) + b + f;

                while (e>1000)
                {
                    int qaliq = e % 10;
                    e = (e - qaliq) / 10;
                    m = (m * 10) + qaliq;
                }
                while (m>0)
                {
                    int qaliq = m % 10;
                    m = (m - qaliq) / 10;
                    n=(n*10) + qaliq;
                }
                int s = l - n;
                
                int q = c + d;

                while (q>1000)
                {
                    int qaliq = q % 10;
                    q = (q - qaliq) / 10;
                    w = (w * 10) + qaliq;
                }
                while (w>0)
                {
                    int qaliq = w % 10;
                    w = (w - qaliq) / 10;
                    r = (r * 10) + qaliq;
                }
                int y = s + r;

                while (e1>0)
                {
                    int qaliq = e1 % 10;
                    e1 = (e1 - qaliq) / 10;
                    t = t + qaliq; ;
                }
                
                while (t>0)
                {
                    int qaliq = t % 10;
                    t = (t - qaliq) / 10;
                    t1 = t1 * 10 + qaliq ;
                }
                
                int x = y + t1;
                
                int x1 = (x * 100) + 11;

                while (e2>0)
                {
                    int qaliq = e2 % 10;
                    e2 = e2 / 10;
                    if (counter % 2 != 0)
                    {
                        t2 = (t2 * 10) + qaliq;
                    }
                    counter++;
                }

                int p = x1 - t2;
                
                int j = p % 10;
                
                p= (p - j) / 10;
                
                p = (p * 100) + 88;
                
                p = (p * 10) + j;

                Console.WriteLine(p);


            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
            
            
        }
    }
}
