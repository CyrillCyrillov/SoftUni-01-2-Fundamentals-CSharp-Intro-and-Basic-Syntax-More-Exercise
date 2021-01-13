using System;

namespace Task05_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 1; i <= numberOfLetters; i++)
            {
                string nextEntry = Console.ReadLine();
                if (nextEntry == "0")
                    {
                        message = message + " ";
                    }
                else
                    {
                        int digits = nextEntry.Length;
                        int mainDigit = int.Parse(nextEntry) % 10;
                        float offset = (mainDigit - 2) * 3;
                        if (mainDigit > 7) offset++;
                        float letterIndex = offset + digits - 1 + 97;
                        message = message + (char)letterIndex;
                    }
            }
            
            Console.WriteLine(message);
        }
    }
}
