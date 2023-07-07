using System;

namespace PrepChallengesG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrepChallenge1();
        }

        static void PrepChallenge1()
        {
            Console.WriteLine("Code Challenge 1");
            int[] nums = new int[5];
            try
            {
                Console.WriteLine("Choose some numbers from 1-10 bwoi.");
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write($"Number {i + 1}: ");
                    string result = Console.ReadLine();
                    bool defValid = int.TryParse(result, out int number);
                    nums[i] = defValid && number >= 1 && number <= 10 ? number : throw new ArgumentException("You don't have the juice brother, try again.");
                }

                Console.WriteLine("\nEntered Numbers");
                foreach (int number in nums)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine("\n\nSelect a number from the selection:");
                string selectionInput = Console.ReadLine();
                bool isValidSelection = int.TryParse(selectionInput, out int selectedNumber);

                string outputMessage = isValidSelection ? $"The score of {selectedNumber} is {CalculateScore(nums, selectedNumber)}." : "Invalid input. Please enter a valid number.";
                Console.WriteLine(outputMessage);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine();
        }

        static int CalculateScore(int[] numbers, int selectedNumber)
        {
            int score = 0;
            foreach (int number in numbers)
            {
                score += number == selectedNumber ? 1 : 0;
            }
            return score;
        }
    }
}

