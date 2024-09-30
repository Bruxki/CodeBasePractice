using System;
					
public class Program
{
	public static void Main()
	{
	string x = "s2wiss";
	Console.WriteLine(AnyNonRepeatedChar(x));
	static string AnyNonRepeatedChar(string x) 
	{
		for (int i = 0; i < x.Length; i++)
		{
			bool found = false;
			for (int j = 0; j < x.Length; j++)
			{
				if (i == j)
					continue;
				if (x[i] == x[j])
				{
				found = true;
				break;
				}
			}
			if (found == false)
				return x[i].ToString(); 
 		}
	 return null;
	}
  }
}
