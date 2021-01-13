using System;

namespace Task04_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomeString = Console.ReadLine();

            for (int i = incomeString.Length - 1; i >= 0; i--)
            {
                Console.Write(incomeString[i]);
            }
        }
    }
}
