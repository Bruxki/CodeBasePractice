using System;

public struct Item
{
	public string name;
	public int weight;
	public double price;
	
}
public class Player
{
	public string playerName;
	public Item[] inventory = new Item[5]; //player inventory
	
	public void InventoryAddItems(Item newItem)
	{
		//check if the weight is below 25
		int weight = 0;
		for (int i = 0; i < inventory.Length; i++)
		{
			weight += inventory[i].weight;
		}
		//if the new item's weight exceeds the limit we return an error message:
		if (newItem.weight + weight >= 25)
		{
			Console.WriteLine("You are carrying too much!");
			return;
		}
		else
		{
			for (int i = 0; i < inventory.Length; i++)
			{
				//check if the slot is empty
				if (string.IsNullOrEmpty(inventory[i].name))
				{
					Console.WriteLine($"{newItem.name} added to inventory.");
					inventory[i] = newItem;
					break;
				}
				
			}
		}
	}
}

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Insert a name");
		Player player = new Player();
		player.playerName = Console.ReadLine().Trim();
		Console.WriteLine("Player name: " + player.playerName);
		
		//creating items:
		Item apple = new Item();
		apple.name = "Apple";
		apple.weight = 1;
		apple.price = 5;
		
		Item sword = new Item();
		sword.name = "Sword";
		sword.weight = 7;
		sword.price = 150;
		
		Item armor = new Item();
		armor.name = "Armor";
		armor.weight = 20;
		armor.price = 500;
		
		Random rnd = new Random();
		
		Console.WriteLine("Press enter to start");
		while (true)
		{
			int x = rnd.Next(3);
			if (x == 0)
			{
				Console.WriteLine($"You've found {apple.name}!");
				if (Answer() == true)
						player.InventoryAddItems(apple);
			}
			else if (x == 1)
			{
				Console.WriteLine($"You've found {sword.name}!");
				if (Answer() == true)
						player.InventoryAddItems(sword);
			}
			else if (x == 2)
			{
				Console.WriteLine($"You've found {armor.name}!");
				if (Answer() == true)
						player.InventoryAddItems(armor);
			}
			Console.WriteLine("Continue search?");
			if (Answer() == true)
				continue;
			else
				break;
		}
	}
static bool Answer()
{
	Console.WriteLine("Take it? y/n");
	string reply;
	reply = Console.ReadLine().Trim();
	if (reply == "y")
		return true;
	else
		return false;
}
		
}
