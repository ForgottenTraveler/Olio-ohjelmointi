internal class Program
{
    private static void Main(string[] args)
    {
        string lukija;
        string filepath = @"d:\harjoitus14.txt";

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
                    case "lisää";
                        LisääMuistiinpano(filepath);
                        break;
                }
            }
        }

    }
}