using System;

public class Program
{
	public static void Main()
	{
		int numberOfRows;
		Console.WriteLine("Please enter a positive whole number.");
		while (!int.TryParse(Console.ReadLine(), out numberOfRows) || numberOfRows <= 0)
		{
			Console.WriteLine("Please enter a valid positive whole number.");
		}
		
		Console.WriteLine();
		for (int i = 1; i <= numberOfRows; i++)
		{
			for (int j = 1; j <= i; j++)
			{
				Console.Write(i);
			}

			Console.WriteLine();
		}
	}
} 
