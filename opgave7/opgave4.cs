namespace opgave7;

class Opgave4
{
    public static void Run()
    {
        Console.WriteLine("Indtast dit navn");
        string navn = Console.ReadLine();
        Console.WriteLine("Indtast din alder");
        int alder = int.Parse(Console.ReadLine());
        Console.WriteLine(Besked(navn, alder));
        Console.ReadKey();
    }

    static string Besked(string navn, int alder) {
        string ret = $"Du hedder {navn} og er {alder} år gammel. ";
        if (alder < 2) {
            ret += "Du er nyfødt";
        }
        else if (alder < 4) {
            ret += "Du er i dagpleje eller vuggestue";
        }
        else if (alder < 6) {
            ret += "Du er i børnehave";
        }
        else if (alder < 19) {
            ret += "Du går i skole";
        }
        else {
            ret += "Nu begynder livet for alvor";
        }
        return ret;
    }
}
