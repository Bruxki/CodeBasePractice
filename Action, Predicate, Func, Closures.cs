using System;
					
public class Program
{
	//check item-pick-up
	public static event Action OnItemCollected;
	
	//rarity check
	static Predicate<int> isRare = x => x%3 == 0;
	
	//counter initialization (code at the end)
	static Func<int> counter = CreateCounter();
	
	//message handlers (using a lambda expression)
	static Action<string> message = msg => Console.WriteLine($"{msg}");
	static Action<string, int> itemPickedUp = (item, total) => Console.WriteLine($"You have picked up a {item} item. Your total is: {total}.");
	
	//this one using a delegate instead (anonymous function)
	static Action<int, int> AddToItems = delegate (int x, int y)
	{
		Console.WriteLine($"Let's add {y}  to your number(why not) the result: {x}" );
	};
	
	//use Func to add 5 to a number
	static Func<int, int, int> addY = (x, y) => x + y;
  
	//A delegate to output a message
	public delegate void MyDelegate(string msg);
	
	public static void Main()
	{
		//initializing a delegate
		MyDelegate del = Console.WriteLine;
		
		int total = 0;
		do
		{
			total = counter();
			if (total < 10)
				Game();
			else
				message("You won");
				break;
			
		}while (true);

    //delegate (message)
		del("That's all folks!");
	}
	public static void Game()
	{
    //subscribing the event
		OnItemCollected += ItemCollection;
		
		message("Press ENTER to collect an item");
		Console.ReadLine();
    //invoking the event
		OnItemCollected?.Invoke();
		//unsubscribing 
		OnItemCollected -= ItemCollection;
	}
	public static void ItemCollection()
	{
		int x = counter();  
		if (isRare(x))
		 	itemPickedUp("rare", x);
		else
			itemPickedUp("regular", x) ;
		
		//we add 5 to the num of items
		AddToItems(addY(x, 5), 5 );
	}
	
	//Func counter
	static Func<int> CreateCounter()
	{
		int count = 0;
		return () => count++;
	}
	
}
