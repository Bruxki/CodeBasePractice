using System;
					
public class Program
{
	public static void Main()
	{
		//results:
		double[] Anna = {90,95,92,76,90};
		double[] Vicky = {75, 45, 97, 80, 67};
		double[] Max = {99, 100, 13, 24, 78};
		double[] Peter = {55, 75, 80, 100,100};
		double[] Eve = {96, 79, 100, 98, 90};
		
		string result1 = GradeCalc(Average(Anna)); //GradeCalc is a method that needs a double as an input, this input comes from Average, that in its turn takes an input from an array "Anna"
		string result2 = GradeCalc(Average(Vicky));
		string result3 = GradeCalc(Average(Max));
		string result4 = GradeCalc(Average(Peter));
		string result5 = GradeCalc(Average(Eve));
		
		Console.WriteLine($"Anna's result: {result1}");
		Console.WriteLine($"Vicky's result: {result2}");
		Console.WriteLine($"Max's result: {result3}");
		Console.WriteLine($"Peter's result: {result4}");
		Console.WriteLine($"Eve's result: {result5}");
		
	}
	public static double Average(double[] grades)
	{
		double sum = 0;
		for(int i = 0; i < grades.Length; i++)
		{
			sum += grades[i];
		}
		return sum/grades.Length;
	}
	public static string GradeCalc(double AvNum)
	{
		if (AvNum >= 90)
		{
			return ("A");
		}
		else if (AvNum >= 80)
		{
			return ("B");
		}
		else if (AvNum >= 70)
		{
			return ("C");
		}
		else
		{
			return ("D");
		}
		
	}
}
