using Harjoitus6eläimet;

internal class Program
{
    static void Main(string[] args)
    { //Näyttää kissan ja koiran nimet. minkä ääni niistä kuulet ja kuinka monta.
        Kissa Elia = new Kissa("Elia", 14);
        Kissa Alias = new Kissa("Alias", 13);

        Elia.ääntele();
        Alias.ääntele();

        Koira Emma = new Koira("Emma", 20);
        Koira Emma2 = new Koira("Emma", -1);

        Emma.ääntele();

        Eläimet.kuinkamonta();
        Kissa.kuinkamonta();
        Koira.kuinkamonta();
    }
}