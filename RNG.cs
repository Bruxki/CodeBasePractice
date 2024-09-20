using System;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine("Guess a number");
		
		while (true)
		{
			Console.WriteLine("\nDo you want to play? (y = yes, n = no)");
			string answer = Console.ReadLine().ToLower().Trim();
			if (answer == "y")
				Console.WriteLine("Welcome aboard! \nLet's start the game!");
			else if (answer == "n")
			{
				Console.WriteLine("\nAlright, see ya!");
				break;
			}
			else
			{
				Console.WriteLine("That's not an answer, try again!");
				continue;
			}
			
			Console.WriteLine("\nInsert a number from 0 to 100");
			string num = Console.ReadLine();
			int number;
			bool isNumber = int.TryParse(num, out number);
			if (isNumber == false)
			Console.WriteLine("\nThat is not a number. Try again!");
			else
			{
				int randomNumber = Randomizer();
				if (number == randomNumber)
				{
					Console.WriteLine("Your input: " + num + "\nComputer input: " + randomNumber);
					Console.WriteLine("Congrats, you won!");
					continue;
				}
				else
				{
					Console.WriteLine("Your input: " + num + "\nComputer input: " + randomNumber);
					Console.WriteLine($"You lose, try again!");
					continue;
				}
			}
		}
		
	}
	static int Randomizer()
	{
		Random rnd = new Random();
		int x = rnd.Next(100);
		return x;
	}
}
