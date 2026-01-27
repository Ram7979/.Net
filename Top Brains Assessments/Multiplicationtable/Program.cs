// See https://aka.ms/new-console-template for more information
using System;
public class program{
    public static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        int upto = int.Parse(Console.ReadLine());
        for(int i=1;i<=upto;i++){
            int ans = n * i;
            Console.WriteLine(ans);

        }


    }
}