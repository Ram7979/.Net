// See https://aka.ms/new-console-template for more information
public class Program{
    public int Largest(int a, int b, int c){
        if(a>=b && a>=c){
            return a;

        }
        else if(b>=a && b>=c){
            return b;

        }
        return c;



    }
    public static void Main(string[] args){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Program p=  new Program();
        int ans = p.Largest(a,b,c);
        Console.WriteLine(ans);

        

    }
}