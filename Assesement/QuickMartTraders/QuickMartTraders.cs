using System;
public class SaleTransaction{
    public string InvoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; }
    public decimal ProfitOrLossAmount { get; set; }
    public decimal ProfitMarginPercent { get; set; }
    static SaleTransaction LastTransaction = null;
    static bool HasLastTransaction = false;
    public static void Register(){
        SaleTransaction Sobj = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        Sobj.InvoiceNo = Console.ReadLine();
        if (Sobj.InvoiceNo == ""){
            Console.WriteLine("Invoice No cannot be empty");
            return;
        }

        Console.Write("Enter Customer Name: ");
        Sobj.CustomerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        Sobj.ItemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out Sobj.Quantity) || Sobj.Quantity <= 0){
            Console.WriteLine("Quantity must be greater than zero");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        if (!decimal.TryParse(Console.ReadLine(), out Sobj.PurchaseAmount) || Sobj.PurchaseAmount <= 0){
            Console.WriteLine("Purchase Amount must be greater than zero");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        if (!decimal.TryParse(Console.ReadLine(), out Sobj.SellingAmount) || Sobj.SellingAmount < 0){
            Console.WriteLine("Selling Amount must be zero or positive");
            return;
        }
        if (Sobj.SellingAmount > Sobj.PurchaseAmount){
            Sobj.ProfitOrLossStatus = "PROFIT";
            Sobj.ProfitOrLossAmount = Sobj.SellingAmount - Sobj.PurchaseAmount;
        }
        else if (obj.SellingAmount < obj.PurchaseAmount){
            Sobj.ProfitOrLossStatus = "LOSS";
            Sobj.ProfitOrLossAmount = Sobj.PurchaseAmount - Sobj.SellingAmount;
        }
        else
        {
            Sobj.ProfitOrLossStatus = "BREAK-EVEN";
            Sobj.ProfitOrLossAmount = 0;
        }

        Sobj.ProfitMarginPercent =(Sobj.ProfitOrLossAmount / Sobj.PurchaseAmount) * 100;

        LastTransaction = Sobj;
        HasLastTransaction = true;

        Console.WriteLine("\nTransaction saved successfully.");
        Console.WriteLine("Status: " + Sobj.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " + Sobj.ProfitOrLossAmount);
        Console.WriteLine("Profit Margin (%): " + Sobj.ProfitMarginPercent);
    }

    public static void View(){
        if (!HasLastTransaction){
            Console.WriteLine("No transaction available. Please create a new transaction first");
            return;
        }

        Console.WriteLine("\n-------------- Last Transaction --------------");
        Console.WriteLine("InvoiceNo: " + LastTransaction.InvoiceNo);
        Console.WriteLine("Customer: " + LastTransaction.CustomerName);
        Console.WriteLine("Item: " + LastTransaction.ItemName);
        Console.WriteLine("Quantity: " + LastTransaction.Quantity);
        Console.WriteLine("Purchase Amount: " + LastTransaction.PurchaseAmount);
        Console.WriteLine("Selling Amount: " + LastTransaction.SellingAmount);
        Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " + LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit Margin (%): " + LastTransaction.ProfitMarginPercent);
    }

    public static void Calculate(){
        if (!HasLastTransaction){
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        if (LastTransaction.SellingAmount > LastTransaction.PurchaseAmount){
            LastTransaction.ProfitOrLossStatus = "PROFIT";
            LastTransaction.ProfitOrLossAmount = LastTransaction.SellingAmount - LastTransaction.PurchaseAmount;
        }
        else if (LastTransaction.SellingAmount < LastTransaction.PurchaseAmount){
            LastTransaction.ProfitOrLossStatus = "LOSS";
            LastTransaction.ProfitOrLossAmount =LastTransaction.PurchaseAmount - LastTransaction.SellingAmount;
        }
        else{
            LastTransaction.ProfitOrLossStatus = "BREAK-EVEN";
            LastTransaction.ProfitOrLossAmount = 0;
        }

        LastTransaction.ProfitMarginPercent =(LastTransaction.ProfitOrLossAmount / LastTransaction.PurchaseAmount) * 100;

        Console.WriteLine("\nRecalculated Result:");
        Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
        Console.WriteLine("Profit/Loss Amount: " + LastTransaction.ProfitOrLossAmount);
        Console.WriteLine("Profit Margin (%): " + LastTransaction.ProfitMarginPercent);
    }

    public static void Main(string[] args){
        while (true)
        {
            Console.WriteLine("\n================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Register();
                    break;
                case "2":
                    View();
                    break;
                case "3":
                    Calculate();
                    break;
                case "4":
                    Console.WriteLine("Thank you. Application closed normally");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
