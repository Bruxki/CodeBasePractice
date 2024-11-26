using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		//initializing students
		List<Student> students = new List<Student>();
		
		students.Add(new Student(11, "Sarah") );
		students.Add(new Student(22, "John") );
		students.Add(new Student(15, "Lira") );
		students.Add(new Student(17, "Patrik") );
		
		//making a list of filtered students (we put 2 arguments: the students List and a lambda expression (instead of creating a separate delegate for it) )
		//List<Student> filteredStudents = FilterStudents (students, x => x.id > 15); // or ending the lambda with a ( ? true : false )
		
		//filtering with a separate predicate (completely unnecesary but possible) - >
		//List<Student> filteredStudents = FilterStudents (students, predicateTEST);
		
		//Or we can use this Linq thingy >> (Some kind of extension (no idea how this works) )
		List<Student> filteredStudents = students.Where(x => x.id > 15).ToList();
		
		foreach (Student x in filteredStudents)
		{
			displayStudents(x.id, x.name);
		}
		
		
	}
	//a special delegate "Action" (void) to output a message
	static Action<int, string> displayStudents = delegate (int x, string y) {Console.WriteLine($"Id: {x} \nName: {y}");};
	
	//theoretical predicate
	static Predicate<Student> predicateTEST = x => x.id > 15;
	
	
	//a special function/method that filters through students using a predicate (that exists only in a lambda impresson form)
	static List<Student> FilterStudents (List<Student> x, Predicate<Student> predicate)
	{
		List<Student> filteredStudents = new List<Student>();
		
		foreach (Student student in x)
		{
			if( predicate(student) )
				filteredStudents.Add(student);
		}
		return filteredStudents;
	}
	
	
	//Creating a student class
	public class Student
	{
		public int id {get; set;}
		public string name {get; set;}
		
		public Student (int id, string name)
		{
			this.id = id;
			this.name = name;
		}
	}
}
