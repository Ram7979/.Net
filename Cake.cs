/*Cake Order Booking Application – C#
Problem Statement

Sam’s brother is opening a cake shop named Cake World and wants to develop an application to book cake orders online.
The application should validate whether the selected cake flavour is available and ensure that the cake quantity is greater than zero. If any of the inputs are invalid, the application must display an appropriate error message.
If the order details are valid, the application should calculate and display the final discounted price of the cake order based on the selected flavour and quantity.

Functional Requirements
Class: Cake

Implement the following properties in the Cake class:

Data Type	Property Name
string	Flavour
int	QuantityInKg
double	PricePerKg
Methods in Cake Class
1. public bool CakeOrder()

This method is used to validate the cake order details.

Validation Rules:

If the cake flavour is Chocolate, Red Velvet, or Vanilla, validation passes.
Otherwise, throw a custom exception InvalidFlavourException with the message:

"Flavour not available. Please select the available flavour"

If the cake quantity is greater than 0, validation passes.
Otherwise, throw a user-defined exception with the message:

"Quantity must be greater than zero"

2. public double CalculatePrice()

This method calculates and returns the discounted price of the cake order.

Discount Calculation

Formula:

Total Price = QuantityInKg × PricePerKg

Discounted Price = Total Price − (Total Price × Discount / 100)

Flavour	Discount (%)
Vanilla	3%
Chocolate	5%
Red Velvet	10%

Note: Flavour comparison is case-sensitive.

Custom Exception

Create a custom exception class named InvalidFlavourException

This class must inherit from the built-in Exception class

Program Class – Main Method

In the Main method:

Accept input values from the user as per the sample input.

Call the CakeOrder() method to validate the order.

Use a try–catch block to handle exceptions thrown by CakeOrder().

If validation is successful, calculate and display the discounted price using CalculatePrice().

Constraints / Notes

All classes and methods must be public

Do not use Environment.Exit()

Follow the given method rules strictly

Do not modify the provided code template

Learning Outcome

Through this application, the developer learns:

How to create and use custom exception classes

How to handle user-defined exceptions

Proper use of try–catch blocks in C#

Sample Inputs and Outputs
Sample Input 1
Enter the flavour
Vanilla
Enter the quantity in kg
5
Enter the price per kg
250

Sample Output 1
Cake order was successful
Price after discount is 1212.5

Sample Input 2
Enter the flavour
Chocolate
Enter the quantity in kg
0
Enter the price per kg
350

Sample Output 2
Quantity must be greater than zero

Sample Input 3
Enter the flavour
Lemon
Enter the quantity in kg
10
Enter the price per kg
150

Sample Output 3
Flavour not available. Please select the available flavour

*/



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

