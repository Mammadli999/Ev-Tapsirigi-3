using System;

namespace Ev_Tapsirigi_3____Task_3
{
    internal class Program
    /* verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi */
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int b;
            int newnumber = 0;
            int qaliq;
            int cem = 0;

            if (a>=100000000 && a<1000000000)
            {
                while (a > 1000000)
                {
                    qaliq = a % 10;
                    a=(a-qaliq) / 10;
                }
                while (a>0)
                {
                    qaliq = a % 10;
                    a = a / 10;
                    newnumber = newnumber * 10 + qaliq;
                }
                while (newnumber>1000)
                {
                    qaliq = newnumber % 10;
                    newnumber=newnumber / 10;
                }
                while (newnumber>0)
                {
                    b = newnumber % 10;
                    newnumber = (newnumber - b) / 10;
                    cem = cem + b;
                    
                }
                Console.WriteLine(cem);


            }
            else
            {
                Console.WriteLine("9 Reqemli Deyil");
            }
        }
    }
}
