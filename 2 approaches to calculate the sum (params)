// 1st variant we use the return thingy:

using System;
					
public class Program
{
	public static void Main()
	{
		int[] x = {10, 100, -99, 58, 77, 3, 56, 21, 17, 5};
		int[] y = {99, -100, 1, 0, 5, 29};
		
		Console.WriteLine(CalculateSum(x));
		Console.WriteLine(CalculateSum(y));
		Console.WriteLine(CalculateSum(1, 2, 3));
		Console.WriteLine(CalculateSum(5, 10, 15, 20));
		
	}
	public static int CalculateSum(params int[] numbers)
	{
		int sum = 0;
		for(int i = 0; i < numbers.Length; i++)
		{
			sum += numbers[i];
		}
		return (sum); // the 'return' thingy
	}
}

// And 2nd: we use the 'out' thingy:
/*
using System;
					
public class Program
{
	public static void Main()
	{
		int[] x = {10, 100, -99, 58, 77, 3, 56, 21, 17, 5};
		int[] y = {99, -100, 1, 0, 5, 29};
		
		int sum, sum2, sum3, sum4;
		
		CalculateSum(out sum, x);
		CalculateSum(out sum2, y);
		CalculateSum(out sum3, 1, 2, 3);
		CalculateSum(out sum4, 5, 10, 15, 20);
		
		Console.WriteLine($" {sum}, {sum2}, {sum3}, {sum4}");
		
	}
	static void CalculateSum(out int sum, params int[] numbers) // the 'out' thingy
	{
		sum = 0;
		for(int i = 0; i < numbers.Length; i++)
		{
			sum += numbers[i];
		}
	}
}
*/
