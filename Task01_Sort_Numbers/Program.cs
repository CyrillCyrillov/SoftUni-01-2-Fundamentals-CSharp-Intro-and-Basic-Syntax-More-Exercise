using System;

namespace Task01_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double min = 0;
            double mid = 0;
            double max = 0;

            if (a >= b && a >= c)
            {
                max = a;
                if (b >= c)
                {
                    mid = b;
                    min = c;
                }
                else
                {
                    mid = c;
                    min = b;
                }
            }

            if (b >= a && b >= c)
            {
                max = b;
                if (a >= c)
                {
                    mid = a;
                    min = c;
                }
                else
                {
                    mid = c;
                    min = a;
                }
            }

            if (c >= b && c >= a)
            {
                max = c;
                if (b >= a)
                {
                    mid = b;
                    min = a;
                }
                else
                {
                    mid = a;
                    min = b;
                }
            }


            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);

        }
    }
}
