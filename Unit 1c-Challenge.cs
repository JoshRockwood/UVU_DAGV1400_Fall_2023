// Challenge #1
using System;

public class Program
{
	public static void Main()
	{
		Random random = new Random();
		int randomNumber = random.Next(1, 11);
		int attempts = 0;
		int guess;
		Console.WriteLine("Welcome to the Random Number Guessing Game!");
		Console.WriteLine("I've selected a number between 1 and 10.");
		Console.WriteLine("Please guess a number between 1 and 10.");
		while (true)
		{
			string input = Console.ReadLine();
			if (int.TryParse(input, out guess))
			{
				attempts++;
				if (guess < 0 || guess > 10)
				{
					Console.WriteLine("Please enter a valid number between 1 and 10.");
				}
				else if (guess < randomNumber)
				{
					Console.WriteLine("Too low! Try again.");
				}
				else if (guess > randomNumber)
				{
					Console.WriteLine("Too high! Try again.");
				}
				else
				{
					Console.WriteLine("You guessed it! Congratulations! You guessed " + randomNumber + " in " + attempts + " attempts.");
					Console.WriteLine("Thank you for playing!");
					break;
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number between 1 and 10.");
			}
		}
	}
}

// Challenge #2
using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] favoriteFoods = new string[3];

            Console.WriteLine("What are your three favorite foods?");
            for (var i = 0; i < favoriteFoods.Length; i++)
            {
                Console.Write((i + 1) + ". ");
                string favoriteFood = Console.ReadLine();
                favoriteFoods[i] = favoriteFood;
            }
            
            foreach (string favoriteFood in favoriteFoods)
            {
                Console.WriteLine("I love " + favoriteFood + "!");
            }
        }
    }
}
