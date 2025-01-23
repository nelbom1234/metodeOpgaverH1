namespace opgave7;

class Opgave2
{
    public static void Run()
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
