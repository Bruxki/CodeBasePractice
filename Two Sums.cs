using System;
					
public class Program
{
	public static void Main()
	{
		int[] array = new int[10];
		Random rnd = new Random();
		//assigning the numbers
		for (int i = 0; i < array.Length; i++)
			array[i] = rnd.Next(10);
		//outputing the numbers in the array
		for (int i = 0; i < array.Length; i++)
			Console.Write(array[i] + " ");
		//input a number
		Console.WriteLine("\nInsert a number from 1-10");
		int x = Int32.Parse(Console.ReadLine());
		bool matchFound = false;
		
		while (matchFound == false)
		{
			for (int i = 0; i< array.Length; i++)
			{
				for (int j = i + 1; j <array.Length - 1; j++)
				{
					if (array[i] + array[j] == x)
						{
							Console.WriteLine($"\nMatch found at: array[{i}] ({array[i]}) + array[{j}] ({array[j]}) = {x}");
							matchFound = true;
						}
				}
			}
			if (matchFound == false)
			{
				Console.WriteLine("No matches found");
				break;
			}
		}
	}
}
