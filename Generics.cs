using System;
					
public class Program
{
	public static void Main()
	{
		int[] intA= {1,2,3};
		float[] flA = {1f, 2f, 3f, 4f};
		string[] strA = {"1","2","100"};
		Print(intA);
		Print(flA);
		Print(strA);
	}
	//generic method
	public static void Print<T>(T[] array)
	{
		foreach (T item in array)
			Console.Write(item + " ");
		Console.WriteLine();
	}
	
}
