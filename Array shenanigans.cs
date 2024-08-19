using System;
					
public class Program
{
	public static void Main()
	{
		int[] array = {1, 2, 10, -25, 31, 107, 54, 67, 3, 188, 256, -57, -2030};
		
		for(int i = 0; i < array.Length; i++) //output in order
		{
			Console.WriteLine(array[i]);
		}
		for(int i = array.Length - 1; i >= 0; i--)
		{
			Console.WriteLine(array[i]); //reversed output
		}
		for(int i = 0; i < array.Length; i += 2)
		{
			Console.WriteLine(array[i]); //skipping every 2nd output
		}
		for(int i = 0; i< array.Length; i++)
		{
			int x = array[i]; //array[queue number of the data]
			if (x % 2 == 0) // if x(number from the array) is divided by 2 with no remainder then..
				{
					Console.WriteLine(x);
				}
		}
		Console.WriteLine("next part");
		for(int i = 0; i < array.Length; i++)
		{
			int x = array[i];
			if (x == 3) // if it so happens that we encounter a "3" the loop stops
				break;
			Console.WriteLine(x);
		}
	}
}