using System;
					
public class Program
{	
	public void Main()
	{	
		Console.WriteLine("What is the temperature outside in Celcius?");
		string userInput = Console.ReadLine();
		
		if (int.TryParse(userInput, out int userNumber))
		{
			if (userNumber > 35 && userNumber > 30)
			{
				Console.WriteLine("Wow that's hot! Stay hydrated and make sure you stay out of the sun for long periods of time!");
			}
			else if (userNumber < 30 && userNumber > 20)
			{
				Console.WriteLine("Sounds like a pleasant day! Enjoy the nice weather!");
			}
			else if (userNumber < 20 && userNumber > 10)
			{
				Console.WriteLine("It's starting to get a little chilly. I'd recommend taking a sweatshirt with you.");
			}
			else if (userNumber < 10 && userNumber > 0)
			{
				Console.WriteLine("It's definitely cold outside! Bring a jacket and watch out for ice!");
			}
			else (userNumber < 0)
			{
				Console.WriteLine("That's super cold! I'd stay inside with a blanket and some hot cocoa!");
			}
		}
	}
}
