using System;

namespace Task03_Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balans = double.Parse(Console.ReadLine());
            string nextGame = string.Empty;
            double gamePrice = 0;
            double spendMoney = 0;

            while (true)
            {
                nextGame = Console.ReadLine();

                if (nextGame == "Game Time")
                    break;

                switch (nextGame)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        break;
                }
                if (balans <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }

                if (gamePrice > balans)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                else
                    {
                        balans -= gamePrice;
                        Console.WriteLine($"Bought {nextGame}");
                        spendMoney += gamePrice;
                    }
            }

            if (balans <= 0)
            {
                Console.WriteLine("Out of money!");
            }

            else
                {
                    Console.WriteLine($"Total spent: ${spendMoney:F2}. Remaining: ${balans:F2}");
                }
        }
    }
}
