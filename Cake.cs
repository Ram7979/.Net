using System;

public class Cake
{
    // variables (as per your code)
    public string flav;
    public int quant;
    public double tp;
    public double dp;

    // Nested custom exception (still ONE class file)
    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message) { }
    }

    public bool cakeOrder(string flav, int quant)
    {
        if (!(flav.Equals("Chocolate") || flav.Equals("Red Velvet") || flav.Equals("Vanilla")))
        {
            throw new InvalidFlavourException(
                "Flavour not available. Please select the available flavour");
        }

        if (quant <= 0)
        {
            throw new Exception("Quantity must be greater than zero");
        }

        return true;
    }

    public double CalcuatePrice(double tp, string flav)
    {
        if (flav.Equals("Vanilla"))
            dp = 3;
        else if (flav.Equals("Chocolate"))
            dp = 5;
        else if (flav.Equals("Red Velvet"))
            dp = 10;

        double discountedPrice = tp - (tp * dp / 100);
        return discountedPrice;
    }

    public static void Main(string[] args)
    {
        Cake c = new Cake();

        Console.WriteLine("Enter the flavour");
        string flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity in kg");
        int kg = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per kg");
        double price = double.Parse(Console.ReadLine());

        try
        {
            c.cakeOrder(flavour, kg);

            double tp = kg * price;
            double result = c.CalcuatePrice(tp, flavour);

            Console.WriteLine("Cake order was successful");
            Console.WriteLine("Price after discount is " + result);
        }
        catch (InvalidFlavourException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
