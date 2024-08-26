using System;
					
public class Program
{
	public static void Main()
	{
		string input = "there are snakes at the zoo";

		Console.WriteLine(input);
		Console.WriteLine(ReverseSentence(input));
		
		string ReverseSentence(string sentence)
		{
			string[] words = sentence.Split(" ");
			string result = "";
			foreach (string word in words)
			{
				result += ReverseWord(word);
			}
			return result;
		}
		string ReverseWord(string word)
		{
			string result = "";
			for (int i = word.Length - 1; i >= 0; i--)
			{
				result += word[i];
			}
			return result.Trim() + " ";
		}
			
			
	}

}
