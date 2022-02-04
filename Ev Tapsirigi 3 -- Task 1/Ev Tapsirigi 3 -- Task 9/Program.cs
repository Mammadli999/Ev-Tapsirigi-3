using System;

namespace Ev_Tapsirigi_3____Task_9
{
    internal class Program
    /*9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439*/
    {
        static void Main(string[] args)
        {
            int a = 123456789;
            int qaliq;
            int NewNumber=0;
            int counter = 1;


            bool isSuccess = (a >= 100000000 && a < 1000000000);

            if (!isSuccess)
            {
                Console.WriteLine("9 Reqemli Deyil");
                return;
            }
            while (a>0)
            {
                qaliq = a % 10;
                a = a / 10;

                if (counter % 2 !=0)
                {
                    NewNumber = NewNumber * 10 + qaliq;
                }
                counter++;
                
            }
            while (NewNumber>0)
            {
                qaliq = NewNumber % 10;
                NewNumber /= 10;

                a = a * 10 + qaliq;
            }
            Console.WriteLine(a);

        }
    }
}
