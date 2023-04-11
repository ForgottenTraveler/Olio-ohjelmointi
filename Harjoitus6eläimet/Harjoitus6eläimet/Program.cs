using Harjoitus6eläimet;

internal class Program
{
    private static void Main(string[] args)
    {
        Kissa Elia = new Kissa("Elia", 14);
        Kissa Alias = new Kissa("Alias", 25);

        Elia.ääntele();
        Alias.ääntele();

        Koira Emma = new Koira("Emma", 9);
        Koira Emma2 = new Koira("Emma2", 12);

        Emma.ääntele();

        Eläimet.kuinkamonta();
        Kissa.kuinkamonta();
        Koira.kuinkamonta();
    }
}