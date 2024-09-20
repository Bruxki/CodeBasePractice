using System;
					
public class Program
{
	public static void Main()
	{
		bool gameOn = true;
		//creating a map
		string[,] map = new string[5,5];
		MapGeneration(map);
		Random rnd = new Random();
		int playerHealth = 100;
		int coins = 0;
		
		while (gameOn)
		{
			MapRendering(map);
			//Player health, coins tab:
			Console.WriteLine($"Player Health: {playerHealth} \nCoins: {coins}");
			Console.ReadLine();
		}
	}
	/*static void PlayerMovement(out int[,] playerPosition)
	{
		Console.WriteLine("Make a move (wasd)");
		
		
		
		
	}*/
	static void MapRendering(string[,] map)
	{
		//Online emulator doesn't allow the updating:
		//Console.Clear();
		for (int i = 0; i < map.GetLength(0); i++)
		{
			for (int j = 0; j < map.GetLength(1); j++)
				Console.Write(map[i,j] + " ");
			
		Console.WriteLine(" ");
		}		
	}
	static void MapGeneration(string[,] map)
	{
		//map generation
		for (int i = 0; i < map.GetLength(0); i++)
		{
			for (int j = 0; j < map.GetLength(1); j++)
				map[i,j] = ".";
		}
	}
}
