using System;
namespace StudentManagementSystem {
    public class Student {
        int rollNo;
        int phy;
        int che;
        int math;

        //clr Property
        public int RollNo {
            set {
                rollNo = value;
            }
            get {
                return rollNo;
            }
        }



        //Auto-Implemented Property
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Total { 
            get{
                return total;

            }
            set{
                total = value;
            }
         }
        public float Percentage { get; set; }

        public int Phy {
            get {
                return phy;
            }
            set {
                if (value >= 0 && value <= 100) {
                    phy = value;
                } else {
                    throw new InvalidOperationException("Invalid Marks");
                }
            }
        }

        public int Che {
            get {
                return che;
            }
            set {
                if (value >= 0 && value <= 100) {
                    che = value;
                } else {
                    throw new InvalidOperationException("Invalid Marks");
                }
            }
        }

        public int Math {
            get {
                return math;
            }
            set {
                if (value >= 0 && value <= 100) {
                    math = value;
                } else {
                    throw new InvalidOperationException("Invalid Marks");
                }
            }
        }


    }
}