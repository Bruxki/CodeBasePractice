using System;
					
public class Program
{
	public static void Main()
	{
		Ford ford = new Ford ("Ford");
		GMC gmc = new GMC();
		gmc.Name = "GMC";
		Toyota toyota = new Toyota("Toyota");
		//toyota.Name = "Toyota";
		
		Console.WriteLine(ford.name);
		Console.WriteLine(gmc.Name);
		Console.WriteLine(toyota.Name);
	}
	//Regular constructor
	public class Ford
	{
		public string name;
		
		public Ford(string name)
		{
			this.name = name;
		}
	}
	//constructor with get-set
	public class GMC
	{
		string name;
		
		public string Name
		{
			get {return name;}
			set {name = value;}
		}
	}
	//auto-implemented properties
	public class Toyota
	{
		public string Name {get; set;}
		//separate constructor for initial setup
		public Toyota (string name)
		{
			Name = name;
		}
	}
}
