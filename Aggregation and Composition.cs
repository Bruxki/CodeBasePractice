ousing System;
					
public class Program
{
	public static void Main()
	{
		RyanGosling Ryan = new RyanGosling();
		Car chevroletMalibu = new Car(Ryan);
		chevroletMalibu.Drive();
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
		Console.WriteLine("Engine starts");
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
	//Composition = part of the "Car" that does not exist outside of it
	Engine engine = new Engine();
	Wheel[] wheels = new Wheel[4];
	
	//Aggregation = part of the "Car" but cotinues to exist outside of it
	// It also could be in other classes like "Hotel","Gas Station", "Heaven(he died in the end of the movie Drive)"
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
