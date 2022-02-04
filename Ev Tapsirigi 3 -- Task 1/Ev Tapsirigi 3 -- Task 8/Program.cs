using System;

namespace Ev_Tapsirigi_3____Task_8
{
    internal class Program
    /*Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap*/
    {
        static void Main(string[] args)
        {
            int a = 44444;
            int qaliq;
            int cem = 0;
            int counter = 1;

            if (a>=10000 && a<100000)
            {
                while (a>100)
                {
                    qaliq = a % 10;
                    a = a / 10;
                    
                    if (counter % 2 != 0)
                    {
                        cem = cem + qaliq;

                    }
                    counter++;
                }
                Console.WriteLine(cem);
            }
            else
            {
                Console.WriteLine("Yanlishdir");
            }
        }
    }
}
