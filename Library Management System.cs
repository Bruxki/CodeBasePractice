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
	//separate method to find books
	public Book? FindBookByTitle(string title)
	{
		for (int i = 0; i < books.Length; i++)
		{
			if (!string.IsNullOrEmpty(books[i].title) && books[i].title.ToLower().Trim().Contains(title.ToLower().Trim()))
			{
				return books[i];
			}
		}
		return null;
	}
}


public class Program
{
	public static void Main()
	{
		Library library = new Library();
		Book newBook = new Book();
		LoadLibraryBooks();
		Console.WriteLine("Welcome to the Library");
		//menu
	while (true)
	{
		
		string answer;
		Menu(out answer);
		//check all books
		
		if (answer == "1")
		{
			CheckAllBooks();
		}
		//check the availability
		else if (answer == "2")
		{
			CheckAvailability();
		}
		//take a book
		else if (answer == "3")
			TakeBook();
		//return a book
		else if (answer == "4")
		{
			ReturnBook();
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
		//Menu method
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
		//Look through all the books
		void CheckAllBooks()
		{
			for (int i = 0; i < library.books.Length; i++)
				{
					if (!string.IsNullOrEmpty(library.books[i].title))

					{
						Console.WriteLine("\nTitle: " + library.books[i].title);
						Console.WriteLine("Author: " + library.books[i].author);
						Console.WriteLine("ISBN: " + library.books[i].isbn);
						Console.WriteLine("Availability: " + library.books[i].isAvailable);
					}
				}
		}
		//Take a book form the library method
		void TakeBook()
		{
			Console.WriteLine("Please name the book you'd like to take.");
			string name = Console.ReadLine().ToLower().Trim();
			Book? book = library.FindBookByTitle(name);
			if (book != null && book.Value.isAvailable)
			{
				Console.WriteLine("You are taking " + book.Value.title);
				for (int i = 0; i < library.books.Length; i++)
				{
					if (library.books[i].title == book.Value.title)
					{
						library.books[i].isAvailable = false;
						break;
					}
				}
			}
			else
				Console.WriteLine(book != null? "This book is unavailable." : "Failed to find a book, try again later.");
		}
		//Return the book to the library method
		void ReturnBook()
		{
			Console.WriteLine("Please name the book you'd like to return.");
			string name = Console.ReadLine().ToLower().Trim();
			for (int i = 0; i < library.books.Length; i++)
			{
				if (library.books[i].title.ToLower().Trim().Contains(name))
				{
					if (library.books[i].isAvailable == false)
					{
						Console.WriteLine("You are returning " + library.books[i].title);
						library.books[i].isAvailable = true;
						return;
					}
					else
					{
						Console.WriteLine("Error: the book is not taken");
						return;
					}
				}
			}
			Console.WriteLine("Error: incorrect name or the book is not from this library");
		}
		//Check availability Method
		void CheckAvailability()
		{
			Console.WriteLine("Please name the title of the book");
			string name = Console.ReadLine().ToLower().Trim();
			for (int i = 0; i < library.books.Length; i++)
			{
				if (library.books[i].title.ToLower().Trim().Contains(name))
				{
					Console.WriteLine("Full Title: " + library.books[i].title + "\nAvailability: " + library.books[i].isAvailable);
					break;
				}
				
			}
			Console.WriteLine("The book was not found, try again later..");
		}
		//Loading the books into the library
		void LoadLibraryBooks()
		{
			Console.WriteLine("Loading the library..");
			//1st book
			library.books[0].title = "Murder!";
			library.books[0].author = "Arnold Bennett";
			library.books[0].isbn = "1-86092-012-8";
			library.books[0].isAvailable = true;
			//2nd book
			library.books[1].title = "The Grass is Always Greener";
			library.books[1].author = "Jeffrey Archer";
			library.books[1].isbn = "1-86092-049-7";
			library.books[1].isAvailable = true;
			//3rd book
			library.books[2].title = "The Higgler";
			library.books[2].author = "A. E. Coppard";
			library.books[2].isbn = "1-86092-010-1";
			library.books[2].isAvailable = false;
			
		}
	}
	
}
