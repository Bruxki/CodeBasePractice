using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine( Rgb(255,255,255) );
	}
  public static string Rgb(int r, int g, int b) 
  {
    return (ToHex(r) + ToHex(g) + ToHex(b));
  }
  public static string ToHex(int x)
  {
    //capping the range 0-255;
    x = Math.Max(0, (Math.Min(x, 255)));
    
    string[] dict = {"0" ,"1" , "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};
    
    int a = x/16;
    int b = x % 16;
    
    return (dict[a] + dict[b]);
  }
}
