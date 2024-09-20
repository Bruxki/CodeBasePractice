using System;
					
public class Program
{
	private static Random rnd = new Random();
	public static void Main()
	{
		
		Console.WriteLine("Guess a Number");
		bool gameOn = true;
		//Are we executing the game? (lvl1 while loop)
		while(gameOn)
		{
			while(true) //( lvl2 while loop)
			{
				Console.WriteLine("\nDo you want to play? (y = yes, n = no)");
				string answer = Console.ReadLine().ToLower().Trim();
				if (answer == "y")
				{
					Console.WriteLine("Welcome aboard! \nLet's start the game!");
					break;
				}
				else if (answer == "n")
				{
					Console.WriteLine("\nAlright, see ya!");
					gameOn = false;
					break;
				}
				else
				{
					Console.WriteLine("That's not an answer, try again!");
					continue;
				}
			}
			//If the answer is no then we exit the game
			if (gameOn == false)
				break;
			
			
			int numberOfTries = 0;
			Console.WriteLine("\nInsert a number from 0 to 100");
			int randomNumber = Randomizer();
			Console.WriteLine(randomNumber);
			//getting an input from the user (lvl2 while loop)
		while (true)
		{		
			string num = Console.ReadLine();
			int number;
			bool isNumber = int.TryParse(num, out number);
			
			if (isNumber == false)
			{
				Console.WriteLine("\nThat is not a number. Try again!");
				continue;
			}
			else
			{
				
				if (number == randomNumber)
				{
					Console.WriteLine("Your input: " + num + "\nComputer input: " + randomNumber);
					Console.WriteLine("Congrats, you won!");
					Console.WriteLine("Number of tries:" + numberOfTries);
					gameOn = false;
					break;
				}
				else
				{
				//next attempts at guessing (lvl3 while loop)
				while (true)
					{
						numberOfTries++;
						Console.WriteLine("\nWrong answer! Do you need a hint? (y/n)");
						string answer2 = Console.ReadLine().ToLower().Trim();
							if (answer2 == "y")
							{
								Console.WriteLine("Here is a hint:");
								Hint(in numberOfTries, in number, in randomNumber);
							}
							else if (answer2 == "n")
								Console.WriteLine("Okay, suit yourself");
							else
								Console.WriteLine("I guess this is a no");
								
						Console.WriteLine("Alright, make another guess");
					Console.WriteLine(numberOfTries);
					//(lvl4 while loop)
					while (true)
					{
						string num2 = Console.ReadLine();
						bool isNumber2 = int.TryParse(num2, out number);
						if (isNumber2 == false)
						{
							Console.WriteLine("Not a number, try again");
							continue;
						}
						else
							break;
					}
					//we are at: (lvl3 while loop)
						if (number == randomNumber)
							{
								Console.WriteLine("Your input: " + num + "\nComputer input: " + randomNumber);
								Console.WriteLine("Congrats, you won!");
								Console.WriteLine("Number of tries: " + numberOfTries);
								gameOn = false;
								break;
							}
						else
							continue;
					//exiting lvl3 loop
					}
				//exiting the else statement
				}
			//exiting lvl2 loop
			}
			//exiting lvl1 loop
			}
		//exiting Main()
		}
		
	}
	static int Randomizer()
	{
		return rnd.Next(100);
	}
	
	static void Hint(in int numberOfAttempts, in int playerNumber, in int computerNumber)
	{
		string x = computerNumber.ToString();
			string y = x.Substring(0,1);
			string z = x.Substring(1,1);
		if (numberOfAttempts <= 1)
		{
			//first hint
			if (playerNumber > computerNumber)
			Console.WriteLine("Your number is too high");
			else
			Console.WriteLine("Your number is too low");
		}
			//second hint
		else if (numberOfAttempts <= 3)
		{
				if (z == null)
				{
					//since the number doesn't have 2 digits we give the player another (first) hint
					if (playerNumber > computerNumber)
					Console.WriteLine("Your number is too high");
					else
					Console.WriteLine("Your number is too low");
				}
				else
					Console.WriteLine($"The first digit of the computer's number is {y}");
		}
			//1st + 2nd hints
		else if (numberOfAttempts <= 5)
		{
			if (playerNumber > computerNumber)
			Console.WriteLine("Your number is too high");
			else
			Console.WriteLine("Your number is too low");
			
			if (z == null)
				{
					Console.WriteLine("The number contains only one digit");
				}
				else
					Console.WriteLine($"Another tip: the first digit of the computer's number is {y}");
			
		}
			//final straightforward hint
		else
			Console.WriteLine("Okay, the number might or might not be: " + computerNumber);
		
	}
}
