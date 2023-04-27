using Harjoitus7Hissi;

internal class Program
{
    private static void Main(string[] args)
    {
        Hissi hissi = new Hissi(1, 6);

        int uusikerros;
        string lukija;
        Console.WriteLine("Tervetuloa käyttämään hissiä. Poistu hissistä kirjoittamalla 'Poistu'");

        while(true)
        {
            Console.WriteLine();
            Console.Write("Anna uusi kerros ({0]) < " + hissi.PalautusMinMax());
            Console.WriteLine();
            lukija = Console.ReadLine();
            
            if (lukija.Equals("Poistu"))
            {
                break;
            }
            bool tarkistus = int.TryParse(lukija, out uusikerros);

            if (tarkistus)
            {
                hissi.Kerros = uusikerros;
            }
            else
            {
                ErrorHelp.Kirjoitaserror("0003; Virheellinen syötetty! Kokeile uudestaan.");
            }
            hissi.tulostanykykerros();
        }
        Console.WriteLine("Poistuttiin hissistä");
    }
}