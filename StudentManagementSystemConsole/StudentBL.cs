using System;
namespace StudentManagementSystem {
    public class StudentBL {
        Student sobj = null;
        public StudentBL() {
            sobj = new Student();
        }
        public void AcceptStudentDetails() {
            try {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Student Management System ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Roll No:");
                sobj.RollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name:");
                sobj.Name = Console.ReadLine();
                Console.WriteLine("Enter Address:");
                sobj.Address = Console.ReadLine();
                Console.WriteLine("Enter Physics Marks:");
                sobj.Phy = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Chemistry Marks:");
                sobj.Che = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Maths Marks:");
                sobj.Math = int.Parse(Console.ReadLine());
            }
            catch (InvalidOperationException e) {
                Console.WriteLine(e.Message);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int Calculate() {
            sobj.Total = sobj.Phy + sobj.Che + sobj.Math;
            return sobj.Total;
        }

        public float CalAvg() {
            sobj.Percentage = sobj.Total / 3.0f;
            return sobj.Percentage;
        }


        public void calcResult(out int myTotal, out float myPercentage) {
            myTotal = sobj.Phy + sobj.Che + sobj.Math;
            myPercentage = myTotal / 3;
        }
    }
}