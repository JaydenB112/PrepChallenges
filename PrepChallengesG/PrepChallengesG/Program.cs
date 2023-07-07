using System;

namespace PrepChallengesG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int Year = 0;
                Console.WriteLine("Pick a Year, any year!");
                Year = int.Parse(Console.ReadLine());
                string message = (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0)) ? "It's a leap year babyy" : "Oh you didn't know? You might wanna call somebody.";
                Console.WriteLine(message);


            } while (true);


            }
    }
}

