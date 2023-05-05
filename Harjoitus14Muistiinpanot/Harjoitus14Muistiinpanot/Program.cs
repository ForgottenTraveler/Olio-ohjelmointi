internal class Program
{
    private static void Main(string[] args)
    {
        string lukija;
        string filepath = @"harjoitus14.txt";

        try
        {
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("Muistiinpanot: ");
                }
            }
            bool poistutaanko = false;
            while (!poistutaanko)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Anna kometo: Lisää, Näytä, Poista, Poistu");
                lukija = Console.ReadLine().ToLower();
                switch (lukija)
                {
                    case "lisää":
                        LisääMuistiinpano(filepath);
                        break;
                    case "näytä":
                        NäytäMuistiinpanot(filepath); 
                        break;
                    case "poista":
                        PoistaMuistiinpanot(filepath); 
                        break;
                    case "poistu":
                        poistutaanko =true;
                        return;
                    default:
                        Console.WriteLine("Annettu komento on virheelinen... anna uusi komento.");
                        break;

                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        static void LisääMuistiinpano(string filepath)
        {
            string lukija = "";
            Console.WriteLine("Kirjoita uusi muistiinpano: \n");
            lukija = Console.ReadLine();
            using (StreamWriter sw = File.AppendText(filepath))
            {
                sw.WriteLine(lukija);
            }
        }
        static void NäytäMuistiinpanot(string filepath)
        {
            Console.WriteLine();
            string[] rivit = File.ReadAllLines(filepath);
            foreach (string rivi in rivit)
            {
                Console.WriteLine(rivi);
            }
        }
        static void PoistaMuistiinpanot(string filepath)
        {
            File.WriteAllText(filepath, "Muistiinpanot: ");
        }

    }
}