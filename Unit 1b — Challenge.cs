// Challenge #1
using System;

public class Program
{
	public void Main()
	{
		Console.WriteLine("What is the temperature outside in Celcius?");
		float temperature;
		while (!float.TryParse(Console.ReadLine(), out temperature))
		{
			Console.WriteLine("Please enter a valid temperature.");
		}

		if (temperature >= 30)
		{
			Console.WriteLine("Wow that's hot! Stay hydrated and make sure you stay out of the sun for long periods of time!");
		}
		else if (temperature >= 20)
		{
			Console.WriteLine("Sounds like a pleasant day! Enjoy the nice weather!");
		}
		else if (temperature >= 10)
		{
			Console.WriteLine("It's starting to get a little chilly. I'd recommend taking a sweatshirt with you.");
		}
		else if (temperature >= 0)
		{
			Console.WriteLine("It's definitely cold outside! Bring a jacket and watch out for ice!");
		}
		else
		{
			Console.WriteLine("That's super cold! I'd stay inside with a blanket and some hot cocoa!");
		}
	}
}
