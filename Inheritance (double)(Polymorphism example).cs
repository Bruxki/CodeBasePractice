using System;
					
public class Program
{
	public static void Main()
	{
		Person bob = new Person ("Bob", 25);
		bob.Print();
		Employee dean = new Employee ("Dean", 26, "worker");
		dean.Print();
		Programmer sam = new Programmer ("Sam", 23, "hard-worker", "programmer");
		sam.Print();
		
		Person[] personList = {bob, dean, sam};
		PrintAll(personList);
		
		//this was supposed to access different classes' Print() up the inheritance tree but it didn't work, idk why..
		//solved: you need to use virtual for the lowest in the tree, and override for the highest ones
		void PrintAll (Person[] list)
		{
			for (int i = 0; i < list.Length; i++)
			{
				list[i].Print();
			}
		}
	}
}
class Person
{
	public string name;
	public int age;
	public Person(string n, int a) {name = n; age = a;}
	
	public virtual void Print()
	{
		Console.WriteLine("I am a Person " + name + age);
	}
}
class Employee : Person
{
	public string Occupation {get;set;}
	public Employee(string name, int age, string occupation)
		: base (name,age)
	{
		Occupation = occupation;
	}
	public override void Print()
	{
		Console.WriteLine("I am an Employee " + name + age + Occupation);
	}
}
class Programmer : Employee
{
	public string Specialization {get; set;}
	
	public Programmer(string name, int age, string occupation, string specialization)
		:base (name,age,occupation)
	{
		Specialization = specialization;
	}
	public override void Print()
	{
		Console.WriteLine("I am a Programmer " + name + age + Occupation + Specialization);
	}
}
