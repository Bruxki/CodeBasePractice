using System;
					
public class Program
{
	public static void Main()
	{
	double tempCelsius = 25.0, tempFahrenheit = 50.0, tempKelvin = 99.0;
	
	double resultFahrenheit = ConvertTemperature(tempCelsius, "CtoF");
	double resultCelsius = ConvertTemperature (tempFahrenheit, "FtoC");
	double resultKelvin = ConvertTemperature (tempCelsius, "CtoK");
	
	Console.WriteLine($"{tempCelsius}°C is {resultFahrenheit}°F");
	Console.WriteLine($"{tempFahrenheit}°F is {resultCelsius}°C");
	Console.WriteLine($"{tempCelsius}°K is {resultKelvin}°K");
	}
	public static double ConvertTemperature(double temperature, string conversionType)
	{
		if (conversionType == "CtoF")
		{
			return (temperature * 9/5) + 32;
		}
		else if (conversionType == "FtoC")
		{
			return (temperature - 32) * 5/9;
		}
		else if (conversionType == "CtoK")
		{
			return (temperature + 273.15);
		}
		else
		{
			throw new ArgumentException("Invalid conversion type");
		}
		
		
	}
}
