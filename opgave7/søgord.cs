namespace opgave7;

class SøgOrd {
    public static void Run() {
        Console.Clear();
        string tekst = ModtagTekst();
        int tal = ModtagTal(tekst.Length);
        string ord = FindOrd(tekst, tal);
        Console.WriteLine($"Det {tal}. ord i din tekst er \"{ord}\"");
    }

    static string ModtagTekst() {
        while (true) {
            Console.WriteLine("Skriv den tekst du vil søge i");
            string? result = Console.ReadLine();
            if (result == null) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            if (result == "") {
                Console.WriteLine("teksten skal indeholde mindst ét tegn. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            return result;
        }
    }

    static int ModtagTal(int len) {
        while(true) {
            Console.WriteLine("Indtast nummeret på det ord du vil finde i teksten");
            string? result = Console.ReadLine();
            int tal;
            if (result == null) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            if (!int.TryParse(result, out tal)) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            if (tal > len) {
                Console.WriteLine("dit tal må ikke være større end antallet ord i teksten. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            return tal;
        }
    }

    static string FindOrd(string tekst, int tal) {
        return tekst.Split(" ")[tal-1];
    } 
}