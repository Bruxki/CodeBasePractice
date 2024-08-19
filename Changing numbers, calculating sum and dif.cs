using System;

public class Program
{
    public static void Main()
    {
        int a = 5;
		int b = 10;
		int sum, dif;
		

		SwapValues(ref a, ref b);
		
		Console.WriteLine($" {a} {b}");
		
		CalculateSumAndDifference(a,b,out sum, out dif);
		
		Console.WriteLine($"Sum of {a} and {b} is {sum}, the difference between them is {dif}");
    }
//Swapping the numbers and using the "ref" logic (thingy) to change the number in the variable directly, no "return" required.
	static void SwapValues(ref int x, ref int y)
	{
		int i;
		i = x;
		x = y;
		y = i;
	}
//Calculating the difference and pulling the results directly also without the "return" thingy
	static void CalculateSumAndDifference(int x, int y, out int sum, out int dif)
	{
		sum = x + y;
		
		if (x > y)
		{
			dif = x - y;
		}
		else if (x < y)
		{
			dif = y - x;
		}
		else
		{
			dif = 0;
		}
	}
}
