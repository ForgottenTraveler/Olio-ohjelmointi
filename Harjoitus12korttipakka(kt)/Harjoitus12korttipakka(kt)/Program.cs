using Harjoitus12korttipakka_kt_;

class Program
{
    private static void Main(string[] args)
    {


        pakka pakka = new pakka();
        Console.WriteLine("Korttipakka: ");
        pakka.Tulostakortti();

        pakka.shuffle();
        Console.WriteLine("\nKorttipakka on sekoitettu: ");
        pakka.Tulostakortti();

        Console.ReadKey();
    }
}