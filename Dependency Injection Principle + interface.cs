using System;
					
public class Program
{
	public static void Main()
	{
		//first create the emails and sms using interface (bc more flexibility)
		IMessageSender email = new EmailSender();
		IMessageSender sms = new SmsSender();
		
		//Now the notifications for each type
		Notification popMail = new Notification(email);
		Notification popSms = new Notification(sms);
		popMail.Send();
		popSms.Send();
		
	}
	public class Notification
	{
		//not instantiating just yet (no field initialization)
		private IMessageSender messageSender;
		
		//instead using a constructor to instantiate 
		public Notification(IMessageSender message)
		{
			messageSender = message;
		}
		
		public void Send()
		{
			messageSender.SendMessage();
		}
		
	}
	//This acts like a buffer
	public interface IMessageSender
	{
		//No need to put anything here, since it would be overriden by dependencies
		void SendMessage();
	}
	
	private class EmailSender : IMessageSender
	{
		public void SendMessage()
		{
			Console.WriteLine("Sending an Email");
		}
	}
	private class SmsSender : IMessageSender
	{
		public void SendMessage()
		{
			Console.WriteLine("Sending an SMS");
		}
	}
}
