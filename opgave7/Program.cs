
namespace opgave7;

class Program
{
    static void Main(string[] args)
    {
        string? result;
        int menuValg;
        bool shouldExit = false;

        while(!shouldExit) {
            MainMenu();
            result = Console.ReadLine();
            if (result == null) {
                Console.WriteLine("Du skal give et gyldigt input. Tryk enter for at prøve igen");
                Console.ReadKey();
                continue;
            }
            if (!int.TryParse(result, out menuValg)) {
                Console.WriteLine("Du skal give et gyldigt input. Tryk enter for at prøve igen");
                Console.ReadKey();
                continue;
            }

            switch(menuValg) {
                case 0:
                    shouldExit = true;
                    continue;
                case 1:
                    opgave1.Run();
                    break;
                case 2:
                    Opgave2.Run();
                    break;
                case 3:
                    Opgave3.Run();
                    break;
                case 4:
                    Opgave4.Run();
                    break;
                case 5:
                    Opgave5.Run();
                    break;
                case 6:
                    Opgave6.Run();
                    break;
                case 7:
                    Temperatur.Run();
                    break;
                case 8:
                    TalFormer.Run();
                    break;
                case 9: 
                    SøgOrd.Run();
                    break;
                default:
                    Console.WriteLine("Det er ikke en gyldig valgmulighed i menuen. tryk enter for at prøve igen.");
                    Console.ReadKey();
                    continue;
            }
            if (AskExit()) {
                break;
            }
        }
    }

    static void MainMenu() {
        PrintMainMenu();
    }

    static void PrintMainMenu() {
        Console.Clear();
        Console.WriteLine("Indtast det nummer du vil åbne");
        Console.WriteLine("1. Hello world");
        Console.WriteLine("2. Udskriv brugerinput");
        Console.WriteLine("3. Aritmetik med 3 tal");
        Console.WriteLine("4. Navn og alder");
        Console.WriteLine("5. Opdel komma-separeret streng");
        Console.WriteLine("6. Gæt et tal-spil");
        Console.WriteLine("7. Temperatur konverteringer");
        Console.WriteLine("8. Konverteringer af tal");
        Console.WriteLine("9. Søg efter ord i tekst");
        Console.WriteLine("0. Luk programmet");
    }

    static bool AskExit() {
        while (true){
            Console.WriteLine("Tast 1 for at afslutte programmet eller en vilkårlig tast for at gå tilbage til hovedmenuen");
            ConsoleKeyInfo svar = Console.ReadKey(true);
            if (svar.Key.ToString() == "D1") return true;
            return false;
        }
    }
}
