namespace opgave3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("indtast et tal");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("indtast et mere");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("indtast et sidste");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("sum:" + Sum3(a,b,c));
        Console.WriteLine("subtraktion: " + Sub3(a,b,c));
        Console.WriteLine("multiplikation: " + Mul3(a,b,c));
        Console.WriteLine("Dvision: " + Div(a,b,c));
        Console.ReadKey();
    }

    static int Sum3(int a,int b, int c) {
        return a + b + c;
    }

    static int Sub3(int a,int b, int c) {
        return a - b - c;
    }

    static int Mul3(int a,int b,int c) {
        return a * b * c;
    }

    static int Div(int a,int b,int c) {
        return (a + b) / c;
    }
}
