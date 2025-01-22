namespace opgave6;

class Program
{
    static void Main(string[] args)
    {
        int svar = Ran();
        int forsøg = 5;


        while (forsøg > 0) {
            Console.WriteLine($"Gæt et tal mellem 1 og 25. Du har {forsøg} forsøg");
            int gæt = int.Parse(Console.ReadLine());
            if (Correct(svar, gæt)) {
                Console.WriteLine("Du har gættet rigtigt! Tillykke");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(HighLow(svar, gæt));
            forsøg--;
        }
        Console.WriteLine("Du er løbet tør for forsøg. Bedre held næste gang");
        Console.ReadKey();
    }

    static int Ran() {
        Random r = new Random();
        return r.Next(1,26);
    }

    static bool Correct(int svar, int gæt) {
        return svar == gæt;
    }

    static string HighLow(int svar, int gæt) {
        if (gæt < svar) {
            return "Gættet var for lavt";
        }
        return "Gættet var for højt";
    }
}
