using System;

class SwapTwoNumbers
{
    public static void Swap1(ref int num1, ref int num2){
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    public static void Swap2(int in1, int in2, out int num1, out int num2){
        num1 = in2;
        num2 = in1;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());
        Swap1(ref num1, ref num2);
        Console.WriteLine($"After Swap1 (ref): num1 = {num1}, num2 = {num2}");
        Swap2(num1, num2, out int out1, out int out2);
        Console.WriteLine($"After Swap2 (out): num1 = {out1}, num2 = {out2}");
    }
}