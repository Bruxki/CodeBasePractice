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
	}
}
class Person
{
	public string name;
	public int age;
	public Person(string n, int a) {name = n; age = a;}
	
	public void Print()
	{
		Console.WriteLine("I am a Person " + name + age);
	}
}
class Employee : Person
{
	public string Occupation {get;set;} = "";
	public Employee(string name, int age, string occupation)
		: base (name,age)
	{
		Occupation = occupation;
	}
	public void Print()
	{
		Console.WriteLine("I am an Employee " + name + age + Occupation);
	}
}
class Programmer : Employee
{
	public string Specialization {get; set;} = "";
	
	public Programmer(string name, int age, string occupation, string specialization)
		:base (name,age,occupation)
	{
		Specialization = specialization;
	}
	public void Print()
	{
		Console.WriteLine("I am a Programmer " + name + age + Occupation + Specialization);
	}
}
