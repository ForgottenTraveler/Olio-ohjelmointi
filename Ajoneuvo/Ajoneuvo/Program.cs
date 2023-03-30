using Ajoneuvo;

class Program
{
    static void Main(string[] args)
    {
        koira koiraOlio = new koira("Rekku", "Saksanpaimenkoira", 4, "Harmaa", 32.0f);

        koiraOlio.nimi = "Rekku";
        koiraOlio.Rotu = "Saksanpaimenkoira";
        koiraOlio.Ikä = 4;
        koiraOlio.väri = "Harmaa";
        koiraOlio.Paino = 32.0f;

        koiraOlio.Hauku();

        Console.WriteLine(koiraOlio.HaeTiedot());

        koiraOlio.Hauku();
    }
}