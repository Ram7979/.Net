using System;
using System.Collections.Generic;

public abstract class Transaction{
    public int Id {get; set;}
    public DateTime Date{get; set;}
    public decimal Amount{get; set;}
    public string Description{get; set;}
    public abstract string GetSummary();




}
public class ExpenseTransaction: Transaction{
    public string Category{get; set;}
    public override string GetSummary(){
        return "Expense: " + Amount + ", Category: " + Category + ", Note: " + Description;
    }

}

public class IncomeTransaction: Transaction{
    public string Source{get; set;}
    public override string GetSummary()
    {
        return "Income: "+Amount + ", Source: "+Source + ", Note: "+Description;
    }
}

public interface IReportable{
    string GetSummary();

}

public class Ledger<T> where T: Transaction{
    List<T> trans = new List<T>();
    public void AddEntity(T input){
        trans.Add(input);


    }
    public List<T> GetTransactionsByDate(DateTime date){
        List<T> res = new List<T>();
        foreach (var item in trans)
        {
            if (item.Date.Date == date.Date){
                res.Add(item);
            }
        }

        return res;

    }
    public decimal CalculateTotal(){
        decimal total = 0;
        foreach (var item in trans){
            total += item.Amount;
        }
        return total;
    }
    public List<T> GetAll(){
        return trans;
    }


}




public class DigitalCashledger{

    public static void Main(string[] args){
        Ledger<IncomeTransaction> IL = new Ledger<IncomeTransaction>();
        IncomeTransaction IT = new IncomeTransaction();
        IT.Id = 1;
        IT.Date = DateTime.Now;
        IT.Amount = 500;
        IT.Source = "Main Cash";
        IT.Description = "Replenishment";
        IL.AddEntity(IT);

        Ledger<ExpenseTransaction> EL = new Ledger<ExpenseTransaction>();
        ExpenseTransaction ET1 = new ExpenseTransaction();
        ET1.Id = 1;
        ET1.Date = DateTime.Now;
        ET1.Amount = 20;
        ET1.Category = "Office";
        ET1.Description = "Stationery";
        EL.AddEntity(ET1);

        ExpenseTransaction ET2 = new ExpenseTransaction();
        ET2.Id = 2;
        ET2.Date = DateTime.Now;
        ET2.Amount = 15;
        ET2.Category = "food";
        ET2.Description = "Team Snacks";
        EL.AddEntity(ET2);

        decimal incomeTotal = IL.CalculateTotal();
        decimal expenseTotal = EL.CalculateTotal();
        decimal balance = incomeTotal - expenseTotal;

        Console.WriteLine("Total Income: " + incomeTotal);
        Console.WriteLine("Total Expenses: " + expenseTotal);
        Console.WriteLine("Net Balance: " + balance);

        Console.WriteLine("\n--- All Transactions ---");
        List<Transaction> all = new List<Transaction>();
        all.AddRange(IL.GetAll());
        all.AddRange(EL.GetAll());

        foreach (var t in all){
            Console.WriteLine(t.GetSummary());
        }
    }
}