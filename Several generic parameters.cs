using System;

public class Program
{
	public static void Main()
	{
		Person bob = new Person("Bob");
		Person tom = new Person("Tom");
		Message hi = new Message("Hi, Tom, how are you?");
		
		Messenger<Message, Person> telegram = new Messenger<Message, Person>();
		telegram.SendMessage(bob,tom,hi);
	}
	class Messenger<T,P> where T: Message where P: Person
	{
		public void SendMessage(P sender, P receiver, T message)
		{
			Console.WriteLine(sender.Name + " sends " + receiver.Name + " a message: " + message.Text);
		}
	}
	class Person
	{
		public string Name {get; set;}
		public Person(string name) {Name = name;}
	}
	class Message
	{
		public string Text {get; set;}
		public Message(string text) {Text = text;}
	}
}
