namespace opgave7;

class Temperatur {
    
    public static void Run() {
        Console.Clear();
        double temp = ModtagTemp();
        int type = VælgType();
        if (type == 1) {
            Console.WriteLine($"Du har valgt {temp} Celcius. Det konverteres til:");
            Console.WriteLine($"Fahrenheit: {((temp*(9/5.0)) + 32).ToString("#,##0.###")}");
            Console.WriteLine($"Kelvin: {(temp + 273.15).ToString("#,##0.###")}");
            Console.WriteLine($"Réaumur: {(temp * 0.8).ToString("#,##0.###")}");
        }
        else {
            Console.WriteLine($"Du har {temp} Fahrenheit. Det konverteres til");
            Console.WriteLine($"Celcius: {((temp - 32) * (5.0/9)).ToString("#,##0.###")}");
            Console.WriteLine($"Kelvin: {(((temp - 32) * (5.0/9)) + 273.15).ToString("#,##0.###")}");
            Console.WriteLine($"Réaumur: {((temp - 32) * (4.0/9)).ToString("#,##0.###")}");
        }
    }

    static double ModtagTemp() {
        while(true) {
            Console.WriteLine("Indtast hvad temperaturen er");
            string? result = Console.ReadLine();
            double temp;
            if (result == null) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            if (!double.TryParse(result, out temp)) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            return temp;
        }
    }

    static int VælgType() {
        while(true) {
            Console.WriteLine("hvilken type temperatur er det. indtast nummeret");
            Console.WriteLine("1. Celcius");
            Console.WriteLine("2. Fahrenheit");
            string? result = Console.ReadLine();
            if (result == null) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            if (!int.TryParse(result, out var type)) {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
            if (type == 1 || type == 2) {
                return type;
            }
            else {
                Console.WriteLine("Det er ikke et gyldigt input. tryk enter for at prøve igen");
                Console.ReadKey(true);
                continue;
            }
        }
    }
}