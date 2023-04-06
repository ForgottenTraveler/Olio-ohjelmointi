using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albumi_KT_
{
    internal class Albumi
    {
        public string Artisti { get; set; }
        public string Nimi { get; set; }
        public string Genre { get; set; }
        public int Hinta { get; set; }
        public Kappale[] Kappaleet { get; set; }

        public Albumi(string artisti, string nimi,string genre, int hinta, Kappale[] kappaleet)
        {
            Artisti = artisti;
            Nimi = nimi;
            Genre = genre;
            Hinta = hinta;
            Kappaleet = kappaleet;
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine("Albumi: ");
            Console.WriteLine(" -Artisti: " + Artisti);
            Console.WriteLine(" -Nimi: " + Nimi);
            Console.WriteLine(" -Genre: " + Genre);
            Console.WriteLine(" -Hinta: " + Hinta + "e");
        }

        public void TulostaKappaleet()
        {
            Console.WriteLine("Songs: ");
            foreach (Kappale kappale in Kappaleet)
            {
                Console.WriteLine(kappale.Nimi + " (" + kappale.Pituus + ")");
            }
        }
    }

    class Kappale
    {
        public string Nimi { get; set; }
        public string Pituus { get; set; }

        public Kappale(string nimi, string pituus)
        {
            Nimi = nimi;
            Pituus = pituus;
        }
    }
}
