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

// Challenge #2
using System;

public class Program
{
	public static void Main()
	{
		int score;
		Console.WriteLine();
		Console.WriteLine("Please input your score on your test");
		while (!int.TryParse(Console.ReadLine(), out score) || score > 100 || score < 0)
		{
			Console.WriteLine("Please enter a valid score between 0 and 100.");
		}

		char grade;
		if (score >= 90)
		{
			grade = 'A';
		}
		else if (score >= 80)
		{
			grade = 'B';
		}
		else if (score >= 70)
		{
			grade = 'C';
		}
		else if (score >= 60)
		{
			grade = 'D';
		}
		else
		{
			grade = 'F';
		}

		Console.WriteLine("Your grade is:" + grade);
		
		Console.WriteLine();
		Console.WriteLine("What is your favorite subject between Math, Science, Art, and History.");
		string subject = Console.ReadLine();
		
		Console.WriteLine();
		switch (subject)
		{
			case "Math":
			case "Calculus":
			case "Trigonometry":
			case "Geometry":
				Console.WriteLine("Math can be complicated, keep up the great work studying!");
				break;
			case "Science":
				Console.WriteLine("Science is super interesting!");
				break;
			case "Art":
				Console.WriteLine("I bet you're super creative!");
				break;
			case "History":
				Console.WriteLine("It's pretty tough remembering all of those dates!");
				break;
			default:
				Console.WriteLine("That's a great choice too!");
				break;
		}
	}
}
