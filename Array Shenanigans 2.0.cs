using System;
					
public class Program
{
	public static void Main()
	{
		int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
		//block1
		int x = 5;
		int[] largerArray = new int[array.Length +1];
		for (int i = 0; i< array.Length; i++)
		{
			largerArray[i] = array[i];
		}
		largerArray[array.Length] = x;
		array = largerArray;
		
		for(int i = 0; i< largerArray.Length; i++)
		{
			Console.WriteLine(largerArray[i]);
		}
		//block2
		int y = 10;
		int[] array2 = new int[array.Length +1];

		//going the chatGPT way from right to left:

		for(int i = array.Length; i > 0; i --)
		{
			array2[i] = array[i - 1];
		}
		array[2] = y;
		
		for(int i = 0; i < array2.Length; i++)
		{
			Console.WriteLine(array2[i]);
		}
			
		// going the normal way from left to right:

		/* 
		for(int i = 0; i <= array.Length; i++)
		{
			array2[i] = array[i - 1];
		}
		array2[0] = y;
		array2 = array;
		
		for(int i = 0; i < array2.Length; i++)
		{
			Console.WriteLine(array2[i]);
		}
		*/
		//Block 3
		int y = 777;
		int z = 4;
		int[] largerArray = new int[array.Length + 1];
		
		for(int i = 0, j = 0; i < array.Length; i++)
			{
			if (i == z) 
				continue;
			largerArray[i] = array[j];
			j++;
			}
		largerArray[z] = y;
		array = largerArray;
		
		for(int i = 0; i < largerArray.Length; i++)
		{
			Console.WriteLine(largerArray[i]);
		}
	}
}
