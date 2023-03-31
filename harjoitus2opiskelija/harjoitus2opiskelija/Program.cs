using harjoitus2opiskelija;

internal class Program
{
    private static void Main(string[] args)
    {
        int i = 0;

        while (true)
        {
            Random Genname = new Random();
            int Gennamae = Genname.Next(0, 20);
            string[] genename = { "Rekku", "Rakku", "Rokku", "Rekka", "Riukka", "Roani", "Rellas", "Rollas", "Renpa", "Ronpa", "Joule", "juol", "Joum", "Bana", "Bon", "Buyn", "Jan", "Jen", "june", "Roiski", "Ruilis" };

            Random Idgen = new Random();
            int Idgener = Idgen.Next(1, 50);

            Opiskelija OpiskeliaOlio = new Opiskelija(genename[Gennamae], Idgener.ToString(), 25);

            OpiskeliaOlio.Datatulostin();
            OpiskeliaOlio.Opintopisteenmuokkaaja();
            
            i++;
            if (i >= 5)
            {
                break; 
            }
               
        }
        
    }
}