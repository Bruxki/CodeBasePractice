using System;
					
public class Program
{
	public static void Main()
	{
		RyanGosling Ryan = new RyanGosling();
		Car toyota = new Car(Ryan);
		toyota.Drive();
	}
}
public class RyanGosling
{
	public void Drive()
	{
    Console.WriteLine("What do I do?");
		Console.WriteLine("Autism kicks in");
	}
}

public class Engine
{
	public void Drive()
	{
		Console.WriteLine("Engine works");
	}
}
public class Wheel
{
	public void Drive()
	{
		Console.WriteLine("I drive");
	}
}
public class Car
{
	//Composition (part-of)
	Engine engine = new Engine();
	Wheel[] wheels = new Wheel[4];
	
	//Aggregation
	private RyanGosling ryanGosling;
	
	//Constructor
	public Car(RyanGosling ryanGosling)
	{
		//Continuing the aggregation
		this.ryanGosling = ryanGosling;
		
		//initializing the Wheels
		for (int i = 0; i < wheels.Length; i++)
			wheels[i] = new Wheel();
	}
	//Delegation
	public void Drive()
	{
		engine.Drive();
		ryanGosling.Drive();
		
		for (int i = 0; i < wheels.Length; i++)
		{
			wheels[i].Drive();
		} 
	}
}
