// While loop practice
using System;
					
public class Program
{
	public static void Main()
	{
		int i = 0;
		while (i<10)
		{
			Console.WriteLine(i);
			i++;
		}
	}
}

// Do while loop practice
using System;
					
public class Program
{
	public static void Main()
	{
		int i = 9;
		do
		{
			Console.WriteLine(i);
			i++;
		}
		while (i < 8);
	}
}

// For Loop practice
using System;
					
public class Program
{
	public static void Main()
	{
		for (int i = 6; i > 0; i--)
		{
			Console.WriteLine(i);
		}
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		for (int i = 0; i < 10; i = i + 2)
		{
			Console.WriteLine(i);
		}
	}
}

// For Each loop practice
using System;
					
public class Program
{
	public static void Main()
	{
		string[] subClassElements = {"Solar", "Void", "Arc", "Stasis", "Strand"};
		foreach (string element in subClassElements)
		{
			Console.WriteLine(element);
		}
	}
}
