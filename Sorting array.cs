using System;
					
public class Program
{
	public static void Main()
	{
		int[] x = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
 		int z;
		
		for(int i = 0; i < x.Length - 1; i++)
		{
			for(int j = i + 1; j < x.Length; j++)
			{
				if (x[i] > x[j])
				{
					z = x[i];
					x[i] = x[j];
					x[j] = z;
				}
			}
		}
		Console.WriteLine("Output");
		for (int i = 0; i < x.Length; i++)
			{
  			  Console.WriteLine(x[i]);
			}
	}
}
