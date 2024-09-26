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
	public void Earthquake(int population, int water, int food, int money, bool hospital, bool shelter)
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
	public void Hurricane(int population, int water, int food, int money, bool hospital, bool shelter)
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
	public void Drought(int population, int water, int food, int money)
	{
		population -= rnd.Next(50,100);
		water -= rnd.Next(50);
		food -= rnd.Next(20);
		money -= rnd.Next(500,1000);		
	}
	public void Famine(int population, int water, int food, int money)
	{
		water -= rnd.Next(20);
		food -= rnd.Next(50);
		money -= rnd.Next(800,1200);
		population -= rnd.Next(100,150);
	}
	public void GoodDay(int population, int water, int food, int money)
	{
		water += rnd.Next(20);
		food += rnd.Next(20);
		money += rnd.Next(100,1000);
		population += rnd.Next(10,50);		
	}
	public void SunnyDay(int population, int water, int food, int money)
	{
		water += rnd.Next(10);
		food += rnd.Next(10);
		money += rnd.Next(100,500);
		population += rnd.Next(10,30);			
	}
	public void RegularDay(int population, int water, int food, int money)
	{
		water += rnd.Next(5);
		food += rnd.Next(5);
		money += rnd.Next(50,100);
		population += rnd.Next(5,20);		
	}
}
class Actions
{
	public void BuildHospital(bool hospital, int money)
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
	public void BuildFarm(bool farm, int money)
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
	public void BuildShelter(bool shelter, int money)
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
	public void BuildReservoir(bool reservoir, int money)
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
			Day();
			
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
						actions.BuildHospital(city.hospital, city.money);
					break;
					case "2":
						actions.BuildShelter(city.shelter, city.money);
					break;
					case "3":
						actions.BuildFarm(city.farm, city.money);
					break;
					case "4":
						actions.BuildReservoir(city.reservoir, city.money);
					break;
				}
			}
			else
				Console.WriteLine("...");
			Console.WriteLine("Moving on to the next day...");
		}
		
		void Day()
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
				events.GoodDay(city.population, city.water, city.food, city.money); 
				Console.WriteLine("A good day");
			}
				//good day
			else if (x < 20)
			{
				events.SunnyDay(city.population, city.water, city.food, city.money); 
				Console.WriteLine("A sunny day");
			}
				//sunny day
			else if (x < 30)
			{
				events.RegularDay(city.population, city.water, city.food, city.money); 
				Console.WriteLine("A regular day");
			}
				//regular day
			else if (x < 40)
			{
				events.Famine(city.population, city.water, city.food, city.money); 
				Console.WriteLine("A famine");
			}
				//famine
			else if (x < 60)
			{
				events.Drought(city.population, city.water, city.food, city.money); 
				Console.WriteLine("A drought");
			}
				//drought
			else if (x < 70)
			{
				events.Hurricane(city.population, city.water, city.food, city.money, city.hospital, city.shelter); 
				Console.WriteLine("A hurricane");
			}
				//hurricane
			else if (x < 80)
			{
				events.Earthquake(city.population, city.water, city.food, city.money, city.hospital, city.shelter); 
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
			
		}
	}
}
