// Test variable practice
using System;
					
public class Program
{
	public void Main()
	{	
		int x = 32;
		int y = 24;
		if (x > y)
		{
			Console.WriteLine("True, x is greater than y.");
		}
	}
}

// If statement practice
using System;
					
public class Program
{
	public void Main()
	{	
		if (56 < 102)
		{
			Console.WriteLine("True, 56 is less than 102.");
		}
	}
}

// Else statement practice
using System;
					
public class Program
{
	public void Main()
	{
		int x = 75;
		int y = 25;
		if (x < y)
		{
			Console.WriteLine("True");
		}
		else
		{
			Console.WriteLine("False");
		}
	}
}

//Else if statement practice
using System;

public class Program
{
	public void Main ()
	{
	int x = 72;
		if (x <= 100)
		{
			Console.WriteLine("Full");
		}
		else if (x > 75)
		{
			Console.WriteLine("Almost Full");	
		}	
		else 
		{
			Console.WriteLine("Empty");
		}
	}
}

// Switch practice
using System;
					
public class Program
{
	public void Main()
	{
		int directions = 3;
		switch (directions)
		{
			case 1:
				Console.WriteLine("North");
				break;
			case 2:
				Console.WriteLine("South");
				break;
			case 3:
				Console.WriteLine("West");
				break;
			case 4:
				Console.WriteLine("East");
				break;
		}
	}
}

// Default practice
using System;
					
public class Program
{
	public void Main()
	{
		int directions = 5;
		switch (directions)
		{
			case 1:
				Console.WriteLine("North");
				break;
			case 2:
				Console.WriteLine("South");
				break;
			case 3:
				Console.WriteLine("West");
				break;
			case 4:
				Console.WriteLine("East");
				break;
			default:
				Console.WriteLine("You are lost");
				break;
		}
	}
}

// Challenge #1
using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("How hot is it outside?");
		Console.WriteLine("\nWhat is the temperature in Celcius?");
		if (double.TryParse(Console.ReadLine(), out double temperature))
		{
			if (temperature > 30)
			{
				Console.WriteLine("I suggest you stay hydrated and out of the sun for long periods of time!");
			}
			else
			{
				Console.WriteLine("Enjoy the nice weather!");		
			}
		}	
		else
		{
			Console.WriteLine("Input a valid temperature.");
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
	}
}
