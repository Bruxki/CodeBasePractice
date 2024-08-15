using System;
					
public class Program
{
	public static void Main()
	{
		double[] shoppingCart1 = {20, 10, 15, 35, 67, 100, 5};
		double[] shoppingCart2 = {10, 15, 5, 6, 17, 10};
		double[] shoppingCart3 = {5, 17};
		
		double taxes = 1.15; //15 % tax
		double disc = 0.9; //10% discount
		
		double finalPrice1 = AddTax(Discount(CalculateTotalPrice(shoppingCart1),disc),taxes);
		double finalPrice2 = AddTax(Discount(CalculateTotalPrice(shoppingCart2),disc),taxes);
		double finalPrice3 = AddTax(Discount(CalculateTotalPrice(shoppingCart3),disc),taxes);
		
		Console.WriteLine($"Your total is: {finalPrice1}");
		Console.WriteLine($"Your total is: {finalPrice2}");
		Console.WriteLine($"Your total is: {finalPrice3}");
		
	}
	public static double CalculateTotalPrice(double[] price)
	{
		double sum = 0;
		for(int i = 0; i< price.Length; i++)
		{
			sum += price[i];
		}
		return sum;
	}
	public static double Discount(double total, double discountRate)
	{
		return total * discountRate;
	}
	
	public static double AddTax(double discountedTotal, double taxRate)
	{
		return discountedTotal * taxRate;
	}
		
}
