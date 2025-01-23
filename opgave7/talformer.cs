namespace opgave7;

class TalFormer() {
    public static void Run() {
        Console.Clear();
        int tal = ModtagTal();
        string dec = tal.ToString("N2");
        string hex = Hex(tal);
        string bin = Bin(tal);

        Console.WriteLine("Decimal:".PadRight(13) + dec);
        Console.WriteLine("Hexadecimal:".PadRight(13) + hex);
        Console.WriteLine("Binær:".PadRight(13) + bin);

    }

    static int ModtagTal() {
        while(true) {
            Console.WriteLine("Indtast et heltal");
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
            return tal;
        }
    }

    static string Hex(int tal) {
        return Convert.ToString(tal, 16);
    }

    static string Bin(int tal) {
        return Convert.ToString(tal, 2);
    }
}