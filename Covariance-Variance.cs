using System;
					
public class Program
{
	//variance delegate
	delegate Car ReturnCarDel(int id, string name);
	
	//covariance delegates
	delegate void LogIceCarInfoDel (RCar car);
	delegate void LogEvCarInfoDel (EVCar car);
	
	public static void Main()
	{
		//regular example
		EVCar audi = new EVCar();
		audi.Id = 1;
		audi.Model = "A4";
		Console.WriteLine(audi.GetInfo());
		
		//variance example:
		ReturnCarDel rcdel = ReturnCar.ReturnRCar;
		
		Car c1 = rcdel(2, "BMW");
		
		Car c2 =rcdel (3, "Toyota");
		
		Console.WriteLine(c1.GetInfo());
		Console.WriteLine(c1.GetType());
		Console.WriteLine(c2.GetInfo());
		Console.WriteLine(c2.GetType());
		
		//covariance example:
		LogIceCarInfoDel logIceCarInfoDel = LogCarDetails;
		logIceCarInfoDel(c1 as RCar);
		LogEvCarInfoDel logEvCarInfoDel = LogCarDetails;
		logEvCarInfoDel(audi as EVCar);
		
	}
	static void LogCarDetails(Car car)
	{
		if (car is RCar)
		{
			Console.WriteLine($"Object type: {car.GetType()}");
			Console.WriteLine($"Object type: {car.GetInfo()}");
		}
		else if (car is EVCar)
		{
			Console.WriteLine($"Object type: {car.GetType()}");
			Console.WriteLine($"Object type: {car.GetInfo()}");
		}
		else
			throw new ArgumentException();
		
	}
	
	//return car details
	public static class ReturnCar
	{
		public static RCar ReturnRCar(int id, string name)
		{
			return new RCar {Id = id, Model = name};
		}
		public static EVCar ReturnEVCar(int id, string name)
		{
			return new EVCar {Id = id, Model = name};
		}
	}
	//kind of cars:
	//base car
	public abstract class Car
	{
		public int Id {get; set;}
		public string Model {get; set;}
		
		public virtual string GetInfo()
		{
			return $"{Id} - {Model}" ;
		}
	}
	//derived car 1
	public class RCar : Car
	{
		
		public override string GetInfo()
		{
			return $"{base.GetInfo()} - IC engine";
		}
	}
	//derived car 2
	public class EVCar : Car
	{
		public override string GetInfo()
		{
			return $"{base.GetInfo()} - EV engine";
		}
	}
	
}
