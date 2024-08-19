using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("please insert your age");
		int age = Convert.ToInt32(Console.ReadLine());
		int price = age <= 12? 5 : (age >= 65? 7: 10); //Nested ternary operators
		
		Console.WriteLine($"Your price: {price}");
	}
}
