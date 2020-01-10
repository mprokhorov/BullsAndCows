using System;

namespace BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Random();
            string number = "0000", guess = "";
            int g;
            while (number[0] == number[1] || number[0] == number[2] || number[0] == number[3] || number[1] == number[2] || number[1] == number[2] || number[2] == number[3])
            {
                number = generator.Next(1000, 10000).ToString();
            }
            while (guess != number)
            {
                Console.Write("Введите число: ");
                guess = Console.ReadLine();
                if (!int.TryParse(guess, out g) || guess.Length != 4 || guess[0] == guess[1] || guess[0] == guess[2] || guess[0] == guess[3] || guess[1] == guess[2] || guess[1] == guess[2] || guess[2] == guess[3])
                {
                    Console.WriteLine("Неверное число!");
                    continue;
                }
                int bulls = 0, cows = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guess[i] == number[j] && i == j)
                            bulls++;
                        if (guess[i] == number[j] && i != j)
                            cows++;
                    }
                }
                Console.WriteLine(bulls + " быков, " + cows + " коров.");
            }
        }
    }
}
