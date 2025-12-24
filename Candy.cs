using System;

public class Candy
{
    public string Flavour { get; set; }
    public int Quantity { get; set; }
    public int PricePerPiece { get; set; }
    public double TotalPrice { get; set; }
    public double Discount { get; set; }

    public bool ValidateCandyFlavour()
    {
        if (Flavour.Equals("Strawberry") || Flavour.Equals("Lemon") || Flavour.Equals("Mint"))
        {
            return true;
        }
        return false;
    }
}

public class Program
{
    public Candy CalculateDiscountedPrice(Candy candy)
    {
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
        double DP = 0;

        if (candy.Flavour.Equals("Strawberry"))
        {
            DP = 15;
        }
        else if (candy.Flavour.Equals("Lemon"))
        {
            DP = 10;
        }
        else if (candy.Flavour.Equals("Mint"))
        {
            DP = 5;
        }

        candy.Discount = candy.TotalPrice - (candy.TotalPrice * DP / 100);
        return candy;
    }

    public static void Main(String[] args)
    {
        Program p = new Program();
        Candy candy = new Candy();

        Console.WriteLine("Enter the flavour");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity");
        candy.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per piece");
        candy.PricePerPiece = int.Parse(Console.ReadLine());

        if (candy.ValidateCandyFlavour())
        {
            candy = p.CalculateDiscountedPrice(candy);

            Console.WriteLine("Flavour : " + candy.Flavour);
            Console.WriteLine("Quantity : " + candy.Quantity);
            Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
            Console.WriteLine("Total Price : " + candy.TotalPrice);
            Console.WriteLine("Discount Price : " + candy.Discount);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }
}
