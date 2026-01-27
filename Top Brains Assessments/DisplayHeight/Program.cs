// See https://aka.ms/new-console-template for more information
public class Program{
    public string PersonHeight(int h){
        if(h < 150){
            return "Short";

        }
        else if(h <= 150 && h<180){
            return "Average";

        }
        return "Tall";

    }
    public static void Main(string[] args){
        int height = int.Parse(Console.ReadLine());
        Program p = new Program();
        string res = p.PersonHeight(height);
        Console.WriteLine(res);

    }
}