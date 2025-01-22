namespace opgave2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("skriv en besked");
        string result = Console.ReadLine();
        Udskriv(result);
        Console.ReadKey();
    }

    static void Udskriv(string input) {
        Console.WriteLine(input);
    }

}
