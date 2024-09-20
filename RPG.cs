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
		
		//Player location(fixed)
		int playerX = 4;
		int playerY = 2;
		
		while (gameOn)
		{
           
			MapRendering(map);
			//Player health, coins tab:
			Console.WriteLine($"Player Health: {playerHealth} \nCoins: {coins}");
			//reset current position
            map[playerX,playerY] = ".";
			//Player movement
			ConsoleKeyInfo key = Console.ReadKey();
			if (key.Key == ConsoleKey.W && playerX > 0) playerX--;
			else if (key.Key == ConsoleKey.S && playerX < 4) playerX++;
			else if (key.Key == ConsoleKey.A && playerY > 0) playerY--;
			else if (key.Key == ConsoleKey.D && playerY < 4) playerY++;
			
            if (map[playerX,playerY] == "E")
            {
                playerHealth -= rnd.Next(20, 80);
            }
            else if (map[playerX,playerY] == "T")
            {
                coins += rnd.Next(20);
            }
            if (playerHealth <= 0)
            {
            Console.Clear();
            Console.WriteLine("You lost");
            gameOn = false;
            break;
            }
            map[playerX,playerY] = "P";

		}
	}
	
	static void MapRendering(string[,] map)
	{
		Console.Clear();
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
		//Enemy location generation
		Random rnd = new Random();
		int x = rnd.Next(0,4);
		int y = rnd.Next(0,4);
		map[x,y] = "E";
		
		x = rnd.Next(0,4);
		y = rnd.Next(0,4);
		map[x,y] = "E";
		//Treasure generation
		x = rnd.Next(0,4);
		y = rnd.Next(0,4);
		//regenerate if it's the same
		if (map[x,y] == "E")
		{
			x = rnd.Next(0,4);
			y = rnd.Next(4,0);
			map[x,y] = "T";
		}
		else
		map[x,y] = "T";
		
	}
}
