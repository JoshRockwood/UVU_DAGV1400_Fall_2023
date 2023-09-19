using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter a positive whole number.");
		if (int.TryParse(Console.ReadLine(), out int numberOfRows) && numberOfRows > 0)
		{
			Console.WriteLine();
			for (int i = 1; i <= numberOfRows; i++)
			{
				for (int space = 0; space < numberOfRows - i; space++)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write(i);
				}

				Console.WriteLine();
			}
		}
				else
				{
					Console.WriteLine("Please enter a valid positive whole number.");
				}
	}
}
