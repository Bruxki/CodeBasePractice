using System;

public class Program
{
    public static void Main()
    {
	// create products:

        Product product1 = new Product("Hair Brush", 7.0, 35, 0.1);
        Product product2 = new Product("Pencil", 1.2, 155, 0.05);
        Product product3 = new Product("Notebook", 3.5, 50, 0.1);
        
		// calculate all the inventory with discounts and taxes:

		Product[] inventory = {product1, product2, product3};
		
		double salesTax = 0.88; //12%
		
		double totalValue = ApplySalesTax(CalculateInventoryTotal(inventory),salesTax);
		
		Console.WriteLine(totalValue);
    }
	//calculate total products (number * price * discount) + other products

	public static double CalculateInventoryTotal(Product[] products)
	{
		double sum = 0;
		for(int i = 0; i < products.Length; i++)
		{
			sum += products[i].Price * products[i].Quantity;
			sum -= products[i].Price * products[i].Quantity * products[i].DiscountPercentage; // - the tax on the product
		}
		return sum;
	}
	//calculate (total - taxes)

	public static double ApplySalesTax(double productsValue, double taxRate)
	{
		return productsValue * taxRate;
	}
}

// A Product class is created with dif parameters

public class Product
{
    
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public double DiscountPercentage { get; set; }

    
    public Product(string name, double price, int quantity, double discount)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        DiscountPercentage = discount;
    }
}
