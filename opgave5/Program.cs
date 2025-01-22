namespace opgave5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("indtast en række værdier adskilt med kommaer");
        string[] arr = Opdel(Console.ReadLine());
        Console.WriteLine($"størrelsen på arrayet er {arr.Length}");
        foreach (string s in arr) {
            Console.WriteLine(s);
        }
    }

    static string[] Opdel(string s) {
        return s.Split(",");
    }
}
