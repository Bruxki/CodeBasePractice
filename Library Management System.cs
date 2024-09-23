using System;
		
struct Book
{
	public string title;
	public string author;
	public string isbn;
	public bool isAvailable;
}
class Library
{
	public Book[] books = new Book[10];
	
	
	
	
	public void AddBook(Book newBook)
	{
		for (int i = 0; i< books.Length; i++)
		{
			if (string.IsNullOrEmpty(books[i].title))
				{
					Console.WriteLine("Insert the Title of the book");
					books[i].title = Console.ReadLine().Trim();
					Console.WriteLine("Insert the name of the author");
					books[i].author = Console.ReadLine().Trim();
					Console.WriteLine("Insert the ISBN number");
					books[i].isbn = Console.ReadLine().Trim();
					books[i].isAvailable = true;
				break;
				}
		}
	}
}


public class Program
{
	public static void Main()
	{
		Library library = new Library();
		Book newBook = new Book();
		
		Console.WriteLine("Welcome to the Library");
		//menu
		string answer;
		Menu(out answer);
		if (answer == "1")
			FirstOption();
		else if (answer == "2")
			SecondOption();
		
		
		//add a book
		
			
			
			
			
		void AddABook()
		{
			library.AddBook(newBook);
			return;
		}
		void Menu(out string answer)
		{
			Console.WriteLine("\nHere are your options:\n1) Check out all the books\n2) Check out availability of a certain book");
			Console.WriteLine("3) Take a book\n4) Return a book\n5) Add a newbook to the library");
			Console.WriteLine("Please answer with a corresponding number");
			while (true)
			{
				if (Console.ReadLine().ToLower().Trim() == "1")
				{
					answer = "1";
					return;
				}
				else if (Console.ReadLine().ToLower().Trim() == "2")
				{
					answer = "2";
					return;
				}
				else if (Console.ReadLine().ToLower().Trim() == "3")
				{
					answer = "2";
					return;
				}
				else if (Console.ReadLine().ToLower().Trim() == "4")
				{
					answer = "2";
					return;
				}
				else if (Console.ReadLine().ToLower().Trim() == "5")
				{
					answer = "2";
					return;
				}
				else
				{
					Console.WriteLine("Please try again");
					continue;
				}
			}
		void FirstOption()
		{
			for (int i = 0; i < books.Length; i++)
			{
				Console.WriteLine("");
			}
		}
			
		}
	}
	
}
