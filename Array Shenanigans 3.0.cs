using System;
					
public class Program
{
	public static void Main()
	{
	int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
	int x = 44;
	int y = 4;
	int[] newarray = new int[array.Length + 1];
	
	for(int i = 0, j = 0; i <= array.Length; i++) //"<=" so that the last number doesn't get left out
	{	
		if(i == y)
			continue;
		newarray[i] = array[j];
		j++;
	}
	newarray[y] = x;
	array = newarray;
	for(int i = 0; i< array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}
/* //Block 4 we delete an element from the end
	{
	int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
	int[] smolarray = new int[array.Length - 1];
	
	for(int i = 0; i < smolarray.Length; i++)
		{	
			smolarray[i] = array[i];
		}
	array = smolarray;
	for(int i = 0; i< array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}
*/
/* //Block 5 we delete an element from the beginning
	{
	int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
	int[] smolarray = new int[array.Length - 1];
	
	for(int i = 1; i < smolarray.Length; i++) //we go from 1 (skipping the 1st num in the big array)
		{	
			smolarray[i - 1] = array[i];
		}
	array = smolarray;
	for(int i = 0; i< array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	}
*/
/* //Block 6 we delete an element from a certain position (5)
	{
	int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };
	int[] array2 = new int[array.Length - 1];
	int x = 5;
		
	for(int i = 0, j = 0; i < array.Length; i++)	
		{
			if(i == x)
				continue;
		array2[j] = array[i];
		j++;
		}
	array = array2;
	for(int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);
		}
	} 
*/
/* // Block 7 we merge two arrays into one by using a 2d array

	}		
		int[] array1 = { 0, 1, 3 };
		int[] array2 = { 4, 5, 6 };
		int[][] x = {array1, array2}; // a 2d array
		int[] y = new int[array1.Length + array2.Length];
		
		for(int i = 0, j =0; i < x.Length; i++)
		{
			for(int k = 0; k < x[i].Length; k++)
			{
				y[j] = x[i][k];
				j++;
			}
		}
		for(int i = 0; i < y.Length; i++)
		{
			Console.WriteLine(y[i]);
		}
	}
*/ //Get number of rows and columns
	{
		int[,] x = {{1, 4, -5, 80, 71} , {1,2,-100, 56, 99}}; //int[,] for 2 dimension grid-like array, int[][] for jagged-like array
		int rows = x.GetUpperBound(0) + 1;
		int columns = x.GetUpperBound(1) + 1;
		
		Console.WriteLine(rows);
		Console.WriteLine(columns);
	}
/*
}