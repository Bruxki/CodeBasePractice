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
	while (true)
	{
		string answer;
		Menu(out answer);
		//check all books
		if (answer == "1")
		{
			for (int i = 0; i < library.books.Length; i++)
				{
					Console.WriteLine("Title: " + library.books[i].title);
					Console.WriteLine("Author: " + library.books[i].author);
					Console.WriteLine("ISBN: " + library.books[i].isbn);
					Console.WriteLine("Availability: " + library.books[i].isAvailable);
				}
		}
		//check the availability
		else if (answer == "2")
		{
			Console.WriteLine("Please name the title of the book");
			string name = Console.ReadLine().ToLower().Trim();
			for (int i = 0; i < library.books.Length; i++)
			{
				if (library.books[i].title.Contains(name))
				{
					Console.WriteLine("Full Title: " + library.books[i].title + "\nAvailability: " + library.books[i].isAvailable);
					break;
				}
				
			}
		}
		//add a book
		else if (answer == "5")
			AddABook();
		
		
			
			
			
	}		
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
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5")
                {
                    answer = input;
                    return;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
		}
	
	}
	
}
