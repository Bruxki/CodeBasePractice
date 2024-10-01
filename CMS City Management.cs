using System;

struct Stuff
{
	public int population;
	public int water;
	public int food;
	public int money;
	public bool hospital;
	public bool shelter;
	public bool farm;
	public bool reservoir;
	
	Stuff(int population, int water, int food, int money, bool hospital, bool shelter, bool farm, bool reservoir)
	{
		this.population = population;
		this.water = water;
		this.food = food;
		this.money = money;
		this.hospital = hospital;
		this.shelter = shelter;
		this.farm = farm;
		this.reservoir = reservoir;
	}
}

class Events
{
	Random rnd = new Random();
	public void Earthquake(ref int population, ref int water, ref int food, ref int money, ref bool hospital, ref bool shelter)
	{
		if (hospital && shelter)
			population -= rnd.Next(10,50);
		else if (shelter)
			population -= rnd.Next(50,80);
		else if (hospital)
			population -= rnd.Next(150,250);
		else
			population -= rnd.Next(300,400);
		water -= rnd.Next(10);
		food -= rnd.Next(10);
		if (rnd.Next(0,100) > 70)
			hospital = false;
		money -= rnd.Next(1000,4000);
	}
	public void Hurricane(ref int population, ref int water, ref int food, ref int money, ref bool hospital, ref bool shelter)
	{
		if (hospital && shelter)
			population -= rnd.Next(10,50);
		else if (shelter)
			population -= rnd.Next(50,80);
		else if (hospital)
			population -= rnd.Next(80,120);
		else
			population -= rnd.Next(150,250);
		water -= rnd.Next(10);
		food -= rnd.Next(10);
		if (rnd.Next(0,100) > 85)
			hospital = false;
		money -= rnd.Next(700,1500);		
	}
	public void Drought(ref int population, ref int water, ref int food, ref int money)
	{
		population -= rnd.Next(50,100);
		water -= rnd.Next(50);
		food -= rnd.Next(20);
		money -= rnd.Next(500,1000);		
	}
	public void Famine(ref int population, ref int water, ref int food, ref int money)
	{
		water -= rnd.Next(20);
		food -= rnd.Next(50);
		money -= rnd.Next(800,1200);
		population -= rnd.Next(100,150);
	}
	public void GoodDay(ref int population, ref int water, ref int food, ref int money)
	{
		water += rnd.Next(20);
		food += rnd.Next(20);
		money += rnd.Next(100,1000);
		population += rnd.Next(10,50);		
	}
	public void SunnyDay(ref int population, ref int water, ref int food, ref int money)
	{
		water += rnd.Next(10);
		food += rnd.Next(10);
		money += rnd.Next(100,500);
		population += rnd.Next(10,30);			
	}
	public void RegularDay(ref int population, ref int water, ref int food, ref int money)
	{
		water += rnd.Next(5);
		food += rnd.Next(5);
		money += rnd.Next(50,100);
		population += rnd.Next(5,20);		
	}
}
class Actions
{
	public void BuildHospital(ref bool hospital, ref int money)
	{
		if (hospital == false)
		{
			if (money >= 500)
			{
				hospital = true;
				money -= 500;
			}
			else
				Console.WriteLine("Not enough money");
		}
		else
			Console.WriteLine("Already built");
	}
	public void BuildFarm(ref bool farm, ref int money)
	{
		if (farm == false)
		{
			if (money >= 150)
			{
				farm = true;
				money -= 150;
			}
			else
				Console.WriteLine("Not enough money");		
		}
		else
			Console.WriteLine("Already built");
	}
	public void BuildShelter(ref bool shelter, ref int money)
	{
		if (shelter == false)
		{
			if (money >= 700)
			{
				shelter = true;
				money -= 700;
			}
			else
				Console.WriteLine("Not enough money");	
		}
		else
			Console.WriteLine("Already built");
	}
	public void BuildReservoir(ref bool reservoir, ref int money)
	{
		if (reservoir == false)
		{
			if (money >= 200)
			{
				reservoir = true;
				money -= 200;
			}
			else
				Console.WriteLine("Not enough money");		
		}
		else
			Console.WriteLine("Already built");
	}
}

public class Program
{
	public static void Main()
	{
		Actions actions = new Actions();
		Events events = new Events();
		Stuff city = new Stuff();
		//initializing the city stats;
		city.population = 200;
		city.water = 80;
		city.food = 80;
		city.money = 500;
		city.hospital = false;
		city.shelter = false;
		city.farm = false;
		city.reservoir = false;
		int day = 0;
		bool gameOn = true;
		
		while (gameOn)
		{
			Menu();
			Day(ref gameOn);
			
			if (gameOn == false)
				break;
			Console.ReadLine();
		}
		Console.WriteLine("Game Over");
		
		void Menu()
		{
			Console.WriteLine("Current stats are: ");
			Console.WriteLine("City population: " + city.population);
			Console.WriteLine("Amount of water: " + city.water);
			Console.WriteLine("Amount of food: " + city.food);
			Console.WriteLine("Money: " + city.money);
			Console.WriteLine("\nYour buildings:");
			Console.WriteLine("Hospital " + city.hospital);
			Console.WriteLine("Shelter " + city.shelter);
			Console.WriteLine("Farm " + city.farm);
			Console.WriteLine("Reservoir " + city.reservoir);
			
			Console.WriteLine("Do you want to build anything? y/n");
			string answer = Console.ReadLine().ToLower().Trim();
			if (answer == "y")
			{
				Console.WriteLine("Choose a building: 1 = hospital, 2 = Shelter, 3 = Farm, 4 = Reservoir");
				answer = Console.ReadLine().ToLower().Trim();
				switch (answer)
				{
					case "1":
						actions.BuildHospital(ref city.hospital, ref city.money);
					break;
					case "2":
						actions.BuildShelter(ref city.shelter, ref city.money);
					break;
					case "3":
						actions.BuildFarm(ref city.farm, ref city.money);
					break;
					case "4":
						actions.BuildReservoir(ref city.reservoir, ref city.money);
					break;
				}
			}
			else
				Console.WriteLine("...");
			Console.WriteLine("Moving on to the next day...");
		}
		
		void Day(ref bool GameOn)
		{
			Random rnd = new Random();
			int x;
			Console.WriteLine("Next day");
			day++;
			if (day < 5)
				x = rnd.Next(0,20);
			else if (day < 10)
				x = rnd.Next(0,40);
			else if (day < 15)
				x = rnd.Next(0,60);
			else
				x = rnd.Next(0,80);
			
			Console.WriteLine("Today is:");
			if (x < 10)
			{
				events.GoodDay(ref city.population, ref city.water, ref city.food, ref city.money); 
				Console.WriteLine("A good day");
			}
				//good day
			else if (x < 20)
			{
				events.SunnyDay(ref city.population, ref city.water, ref city.food, ref city.money); 
				Console.WriteLine("A sunny day");
			}
				//sunny day
			else if (x < 30)
			{
				events.RegularDay(ref city.population, ref city.water, ref city.food, ref city.money); 
				Console.WriteLine("A regular day");
			}
				//regular day
			else if (x < 40)
			{
				events.Famine(ref city.population, ref city.water, ref city.food, ref city.money); 
				Console.WriteLine("A famine");
			}
				//famine
			else if (x < 60)
			{
				events.Drought(ref city.population, ref city.water, ref city.food, ref city.money); 
				Console.WriteLine("A drought");
			}
				//drought
			else if (x < 70)
			{
				events.Hurricane(ref city.population, ref city.water, ref city.food, ref city.money, ref city.hospital, ref city.shelter); 
				Console.WriteLine("A hurricane");
			}
				//hurricane
			else if (x < 80)
			{
				events.Earthquake(ref city.population, ref city.water, ref city.food, ref city.money, ref city.hospital, ref city.shelter); 
				Console.WriteLine("An earthquake");
			}
				//earthquake
			//regular stuff
			city.food -= (city.population / 10 );
			city.water -= (city.population / 10 );
			city.money += city.population;
			if (city.hospital == true)
				city.population += 200;
			else
				city.population += 100;
			if (city.farm == true)
				city.food += 80;
			else
				city.food += 30;
			if (city.reservoir == true)
				city.water += 80;
			else
				city.water += 30;
			if (city.water < 0)
			{
				city.population -= Math.Abs(city.water * 10);
				Console.WriteLine("Population doesn't have enough water, "+ Math.Abs(city.water * 10) + " has died");
				city.water = 0;
			}
			if (city.food < 0)
			{
				city.population -= Math.Abs(city.food * 10);
				Console.WriteLine("Population doesn't have enough food, "+ Math.Abs(city.food * 10) + " has died");
				city.food = 0;
			}
			Console.WriteLine("Population left: "+ city.population);
			if (city.population <= 0)
			{
				GameOn = false;
			}
			
		}
	}
}
