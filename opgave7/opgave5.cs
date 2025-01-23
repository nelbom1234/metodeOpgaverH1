namespace opgave7;

class Opgave5
{
    public static void Run()
    {
        Console.WriteLine("indtast en række værdier adskilt med kommaer");
        string[] arr = Opdel(Console.ReadLine());
        Console.WriteLine($"størrelsen på arrayet er {arr.Length}");
        foreach (string s in arr) {
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }

    static string[] Opdel(string s) {
        return s.Split(",");
    }
}
