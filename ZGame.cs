using System;

struct Point
{
	public int x,y;
	public Point(int x, int y)
	{
		this.x = x;
		this.y = y;
	}
}

class Game
{
	//Random rnd = new Random(); doesn't work on an online emulator properly
	string[,] map = new string[5,5];
	
	public Point player, zombie1, zombie2;
	
	bool alive = true;
	public int score = 0;
	
	public Game()
	{
		player = new Point(2,2);
		zombie1 = new Point(4,0);
		zombie2 = new Point(1,4);
	}
	public void PlayerMovement()
	{
		string input = Console.ReadLine();
		switch (input)
		{
			case "w":
				if (player.x > 0) player.x--;//up
				break;
			case "a":
				if (player.y > 0) player.y--;//left
				break;
			case "s":
				if (player.x < 4) player.x++;//down
				break;
			case "d":
				if (player.y < 4) player.y++;//right
				break;
			default:
				break;
		}
		score++;
	}
	public void ZombieMovement()
	{
		//zombie1
		if (score % 2 == 0)
		{
			if (zombie1.x < player.x) zombie1.x++;
			else if (zombie1.x > player.x) zombie1.x--;
		}
		if (score % 3 == 0)
		{
			if (zombie1.y < player.y) zombie1.y++;
			else if (zombie1.y > player.y) zombie1.y--;
		}
		//zombie2
		if (score % 3 == 0)
		{
			if (zombie2.x < player.x) zombie2.x++;
			else if (zombie2.x > player.x) zombie2.x--;
		}
		if (score % 2 == 0)
		{
			if (zombie2.y < player.y) zombie2.y++;
			else if (zombie2.y > player.y) zombie2.y--;
		}
	}
	public void Render()
	{
		//map reset
		for (int i = 0; i < map.GetLength(0); i++)
		{
			for (int j = 0; j < map.GetLength(1); j++)
			{
				map[i,j] = ".";
			}
		}
		map[player.x,player.y] = "P";
		map[zombie1.x,zombie1.y] = "Z";
		map[zombie2.x,zombie2.y] = "Z";
		Console.WriteLine(score);
		
		for (int i = 0; i< map.GetLength(0); i++)
		{
			for (int j = 0; j < map.GetLength(1); j++)
			{
				Console.Write(map[i,j]);
			}
			Console.WriteLine();
		}
		Console.WriteLine("wasd + enter for control");
	}
	public void Run()
	{
		Render();	
		while(alive)
		{
			PlayerMovement();
			if (score % 3 == 0) ZombieMovement();
			Render();
			CollisionCheck();
		}
		Console.WriteLine("Game Over, your score: " + score);
	}
	public void CollisionCheck()
	{
		if (player.x == zombie1.x && player.y == zombie1.y)
			alive = false;
		if (player.x == zombie2.x && player.y == zombie2.y)
			alive = false;
	}
}
public class Program
{
	public static void Main()
	{
		Game game = new Game();
		game.Run();
	}

}
