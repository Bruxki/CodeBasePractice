using System;
					
public class Program
{
	public static void Main()
	{
		Person bob = new Person("Bob", 11);
		bob = new Employee("Sam", 33, "Microsoft");
		//bob.Print(); - can't print it since bob is still a person??
		Employee dean = new Employee("Dean",24, "Unity");
		dean.Print();
	}
}
class Person
{
	public string Name {get; set;}
	public int age {get; set;}
	
	public Person()
	{
		Name = "No name";
	}
	public Person (string name)
	{
	  	Name = name;
	  	Console.WriteLine(3);
	}
	public Person (string name, int age) 
	  : this(name)
	{
		this.age = age;
	
	  Console.WriteLine(2);
	}
	
}
class Employee : Person
{
	public string Company {get; set;}
	public Employee(string name, int age, string company)
	  : base(name, age)
	{
		Company = company;
		Console.WriteLine(1);
	}
	public void Print()
	{
		Console.WriteLine(Name + age + Company);
	}
}
