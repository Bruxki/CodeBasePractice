using System;
					
public class Program
{
	public static void Main()
	{
	double num1 = 10, num2 = 19;
	
	double result1 = PerformOperation(num1, num2, "add");
	double result2 = PerformOperation(num1, num2, "subtract");
	double result3 = PerformOperation(num1, num2, "multiply");
	double result4 = PerformOperation(num1, num2, "divide");
		
		Console.WriteLine($"{result1}");
		Console.WriteLine($"{result2}");
		Console.WriteLine($"{result3}");
		Console.WriteLine($"{result4}");
		
	}
	public static double PerformOperation(double x, double y, string operationType)
	{
		if(operationType == "add")
		{
			return x + y;
		}
		else if(operationType == "subtract")
		{
			return x - y;
		}
		else if(operationType == "multiply")
		{
			return x * y;
		}
		else if(operationType == "divide")
		{
			return x / y;
		}
		else
		{
			throw new ArgumentException("invalid");
		}
	}
}
