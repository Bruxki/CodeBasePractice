using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
   		//examples
		Console.WriteLine(ConvertFromRoman("MMMCMLXXV") );
		Console.WriteLine(ConvertToRoman(3500) );
	}
	public static string ConvertToRoman(int num)
	{
		string final = "";
		
		for (int i = 0; i < LookUp.lookUpNumbers.Length; i++)
		{
			while (num - LookUp.lookUpNumbers[i] >= 0)
			{
				num -= LookUp.lookUpNumbers[i];
				final += LookUp.lookUpLetters[i];
			}
		}
		return final;
	}
	public static int ConvertFromRoman(string num)
	{
		int number = 0;
		//going through all the letters in the roman number
		for (int i = 0, k = 0; i < num.Length; i++, k++)
			//going through all the letters in our library
			for (int j = 0; j < LookUp.lookUpLetters.Length; j++)
			{
			//here we check if we have a 'double' roman number (IV, IX, etc.)
			//since the last number can't be 'double' we check every 2-symbol-pair but the last
			if (i < num.Length - 1 && num[i].ToString() + num[i+1].ToString() == LookUp.lookUpLetters[j])
			{
				number += LookUp.lookUpNumbers[j];
				//skipping over 1 symbol
				i++;
				//if found break, so we don't count it twice
				break;
			}
			else if (num[i].ToString() == LookUp.lookUpLetters[j])
				number += LookUp.lookUpNumbers[j];
			}
		
		return number;
	}
	//Library with all the letters and corresponding values (same id)
	static class LookUp
	{
		public static string[] lookUpLetters = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
		public static int[] lookUpNumbers = {1000,   900,  500,  400, 100,  90,   50,  40,   10,  9,    5,    4,   1 };
	}

}
