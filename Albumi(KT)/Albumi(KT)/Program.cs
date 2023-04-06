using Albumi_KT_;

internal class Program
{
    private static void Main(string[] args)
    {
        Kappale[] kappaleet = {
                new Kappale("--- Nimi: Snail's House - bloom", "2:40"),
                new Kappale("--- Nimi: Snail's House - if (ujbeats vol.1)", "3:53"),
                new Kappale("--- Nimi: Snail's House - amayadori", "3:14"),
                new Kappale("--- Nimi: Snail's House - d'amour (ujbeat mix)", "2:29"),
                new Kappale("--- Nimi: Snail's House - ramune (ujbeats mix)", "3:18"),
                new Kappale("--- Nimi: Snail's House - sweetheart", "2:02"),
                new Kappale("--- Nimi: Snail's House - Thinkin' of u.", "2:27"),
                new Kappale("--- Nimi: Snail's House - dear", "3:23")
            };

        Albumi albumi = new Albumi("Ujico*/Snail's House", "ujbeats vol.1" ,"JPop", 25, kappaleet);

        albumi.TulostaAlbumi();
        albumi.TulostaKappaleet();

    }
}