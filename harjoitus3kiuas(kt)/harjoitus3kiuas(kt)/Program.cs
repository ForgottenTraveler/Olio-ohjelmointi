using harjoitus3kiuas_kt_;

internal class Program
{
    private static void Main(string[] args)
    { //Näyttää kiuas tiedot
        Kiuas kiuas = new Kiuas("Testikiuas", 0, 0, false);
        kiuas.TulostaTiedot();

        kiuas.VaihdaLampotila(60);
        kiuas.VaihdaKosteus(40);
        kiuas.TulostaTiedot();

        kiuas.Tila = true;
        kiuas.TulostaTiedot();

        Console.ReadKey();
    }
}