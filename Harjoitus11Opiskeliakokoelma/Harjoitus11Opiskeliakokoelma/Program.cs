using Harjoitus11Opiskeliakokoelma;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string lukija = "";
        while (true) 
        {
            Console.WriteLine();
            Console.WriteLine("Olet kommennoissa jonka voit valita: Näytä, Lisää, Poista tai Poistu");
            lukija = Console.ReadLine().ToLower();

            switch(lukija)
            {
                case "näytä":
                    Manageri.Tulostakokoelma();
                    break;
                case "lisää":
                    Lisää();
                    break;
                case "poista":
                    Poista();
                    break;
                case "poistu":
                    Console.WriteLine("Poistutaan kommenosta");
                    return;
                default:
                    Console.WriteLine("Virheellinen syötelmä... yritä uudelleen");
                    break;
            }
        }
    } 
    static void Lisää()
    {
        string etunimi = "";
        string sukunimi = "";
        Console.WriteLine();
        Console.WriteLine("Anna Uuden opiskelijan tiedot: ");
        Console.WriteLine();
        Console.Write("Etunimi: ");
        etunimi = Console.ReadLine();
        Console.Write("Sukunimi: ");
        sukunimi = Console.ReadLine();
        Manageri.lisääopiskelija(etunimi, sukunimi);
    }
    static void Poista()
    {
        if (Manageri.Opiskelijat.Count == 0)
        {
            Console.WriteLine("Kokoelma on tyhjä...");
            return;
        }
        Manageri.Tulostakokoelma();

        int lukijaIndex;
        int opiskelijamäärä = Manageri.Opiskelijat.Count;
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Ketkä poistetaan kokoelmasta? Valitse väliltä {0} - {1} > ",1,opiskelijamäärä);
            bool result = int.TryParse(Console.ReadLine(), out lukijaIndex);
            if (result)
            {
                if (lukijaIndex <= opiskelijamäärä && lukijaIndex > 0)
                {
                    Manageri.PoistaOpiskelija(lukijaIndex - 1);
                    break;
                }
                else
                {
                    Console.WriteLine("virheelinen valinta, anna uusi valinta");
                }
            }
            else 
            {
                Console.WriteLine("virheelinen syöttö, syöttämäsi ei kelpaa... syötöksi kelpaa vain numerot");

            }
        }
    }

}
   


