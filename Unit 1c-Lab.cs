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

// Array practice
using System;
					
public class Program
{
	public static void Main()
	{
		string[] justiceLeague = {"Super Man", "Wonder Woman", "Batman", "The Flash", "Aquaman", "Green Lantern", "Cyborg"};
		Console.WriteLine(justiceLeague[2]);
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] justiceLeague = {"Super Man", "Wonder Woman", "Batman", "The Flash", "Aquaman", "Green Lantern", "Cyborg"};
		justiceLeague[2] = "Nightwing";
		Console.WriteLine(justiceLeague[2]);
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] justiceLeague = {"Super Man", "Wonder Woman", "Batman", "The Flash", "Aquaman", "Green Lantern", "Cyborg"};
		Console.WriteLine(justiceLeague.Length);
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] justiceLeague = {"Super Man", "Wonder Woman", "Batman", "The Flash", "Aquaman", "Green Lantern", "Cyborg"};
		for (int members = 0; members < 7; members++)
		{
			Console.WriteLine(justiceLeague[members]);
		}
	}
}

using System;
					
public class Program
{
	public static void Main()
	{
		string[] justiceLeague = {"Super Man", "Wonder Woman", "Batman", "The Flash", "Aquaman", "Green Lantern", "Cyborg", "Shazam"};
		foreach (string i in justiceLeague)
		{
			Console.WriteLine(i);
		}
	}
}
