using System;
					
public class Program
{
    public static Random rnd = new Random();
	public static void Main()
	{
		bool gameOn = true;
		//creating a map
		string[,] map = new string[5,5];
		MapGeneration(map);
		
		int playerHealth = 100;
		int coins = 0;
       		int lvl = 0;
		//Player location(fixed)
		int playerX = 4;
		int playerY = 2;

		while (gameOn)
		{
			MapRendering(map);
			//Player health, coins tab:
			Console.WriteLine($"Player Health: {playerHealth} \nCoins: {coins} \nLevel: {lvl}");
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
                switch (lvl)
                {
                    case 0:
                    playerHealth -= rnd.Next(20, 80);
                    break;
                    case 1:
                    playerHealth -= rnd.Next(20,50);
                    break;
                    case 2:
                    playerHealth -= rnd.Next(10,30);
                    break;
                    default:
                    playerHealth -= rnd.Next(10);
                    break;
                }
                lvl += rnd.Next(0,2);
            }
            else if (map[playerX,playerY] == "T")
            {
                coins += rnd.Next(20);
                playerHealth += rnd.Next(25,75);
                lvl += rnd.Next(0,2);
            }
            if (playerHealth <= 0)
            {
                Console.Clear();
                Console.WriteLine("You lost");
                gameOn = false;
                break;
            }
            if (lvl >= 5)
            {
                Console.Clear();
                Console.WriteLine("You won!");
                gameOn = false;
                break;
            }
            //Is the map empty and needs to be regenerated?
            if (MapEmptiness(map) == true)
            {
                MapGeneration(map);
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
static bool MapEmptiness(string[,] map)
{
	for (int i = 0; i < map.GetLength(0); i++)
	{
		for (int j = 0; j < map.GetLength(1); j++)
		{
     		   if (map[i,j] == "E")
       			{
        		 return false;
       			}
        		 else if (map[i,j] == "T")
       			{
      		 	 return false;
       			}
		}
	}
 return true;
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
		int x = rnd.Next(0,4);
		int y = rnd.Next(0,4);
		map[x,y] = "E";
		//2nd Enemy
        do
        {
            x = rnd.Next(0,4);
		    y = rnd.Next(0,4);
        }
        while (map[x,y] == "E");
		map[x,y] = "E";
		//Treasure generation
        do
        {
            x = rnd.Next(0,4);
		    y = rnd.Next(0,4);
        }
        while (map[x,y] == "E");
		map[x,y] = "T";
	}
}
