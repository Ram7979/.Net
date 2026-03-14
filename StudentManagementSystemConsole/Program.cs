// See https://aka.ms/new-console-template for more information
//onsole.WriteLine("Hello, World!");
using StudentManagementSystem;

StudentBL sblobj = new StudentBL();
sblobj.AcceptStudentDetails();

//sblobj.Calculate();
//sblobj.calAvg();
System.Console.WriteLine("Total Marks:"+sblobj.Calculate());
System.Console.WriteLine("Percentage:"+sblobj.CalAvg());

