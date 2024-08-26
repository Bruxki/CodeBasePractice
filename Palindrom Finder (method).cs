using System;
					
public class Program
{
	public static void Main()
	{
		string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

		Console.WriteLine("Is it a palindrome?");
		
		foreach (string word in words)
		{
			Console.WriteLine($"Word {word} is a palendrome: {IsPalindrome(word)}");
		}	
	}
	static bool IsPalindrome(string word)
	{
		string word1 = word;
		string word2 = "";
		for (int i = word.Length - 1; i >= 0; i--)
		{
			word2 += word[i];
		}
		return (word1 == word2? true : false);
		
	}
}
