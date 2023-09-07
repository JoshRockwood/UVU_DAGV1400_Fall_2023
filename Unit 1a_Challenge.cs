using System;
					
public class Program
{
	// Created new classes
	public DestinyClass titan; 
	public DestinyClass hunter;
	public DestinyClass warlock;
	
	public void Main()
	{
		// Created instance of classes
		titan = new DestinyClass();
		hunter = new DestinyClass();
		warlock = new DestinyClass();
			
		// Setting the values of classes
		titan.type = "Titan";
		hunter.type = "Hunter";
		warlock.type = "Warlock";
		
		titan.lightLevel = 1830;
		hunter.lightLevel = 1810;
		warlock.lightLevel = 1805;
		
		titan.experience = 9.75f;
		hunter.experience = 8.23f;
		warlock.experience = 3.56f;
		
		// Displayed stats on Console
		Console.WriteLine("Destiny Class\n");
		Console.WriteLine(titan.type);
		Console.WriteLine("Light Level:" + titan.lightLevel);
		Console.WriteLine("Exp:" + titan.experience);
		
		Console.WriteLine("\n" + hunter.type);
		Console.WriteLine("Light Level:" + hunter.lightLevel);
		Console.WriteLine("Exp:" + hunter.experience);
		
		Console.WriteLine("\n" + warlock.type);
		Console.WriteLine("Light Level:" + warlock.lightLevel);
		Console.WriteLine("Exp:" + warlock.experience);
		
		// Killed an enemy and gained experience
		titan.experience += 0.02f;
		hunter.experience += 0.02f;
		warlock.experience += 0.02f;
		
		Console.WriteLine("\n\nEnemy Defeated");
		Console.WriteLine("\nTitan Exp:" + titan.experience);
		Console.WriteLine("Hunter Exp:" + hunter.experience);
		Console.WriteLine("Warlock Exp:" + warlock.experience);
	}
}

// Defined Destiny Class
public class DestinyClass
{
	public string type;
	public int lightLevel = 1830;
	public float experience = 9.75f;
}
