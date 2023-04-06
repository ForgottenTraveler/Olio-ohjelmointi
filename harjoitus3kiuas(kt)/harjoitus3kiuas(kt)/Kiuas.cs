using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus3kiuas_kt_
{
    internal class Kiuas
    {
        public string Nimi { get; set; }
        public int Lampotila { get; set; }
        public int Kosteus { get; set; }
        public bool Tila { get; set; }

        public Kiuas(string kiuas, int lampotila, int kosteus, bool tila)
        {
            Nimi = kiuas;
            Lampotila = lampotila;
            Kosteus = kosteus;
            Tila = tila;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine("Kiuas: " + Nimi);
            Console.WriteLine("Lampotila: " + Lampotila);
            Console.WriteLine("Kosteus: " + Kosteus);
            Console.WriteLine("Tila: " + (Tila ? "päällä" : "pois päältä"));
        }
        public void VaihdaLampotila(int uusiLampotila)
        {
            Lampotila = uusiLampotila;
            Console.WriteLine("Uusi lämpötila asetettu: " + uusiLampotila);
        }


        public void VaihdaKosteus(int uusiKosteus)
        {
            Kosteus = uusiKosteus;
            Console.WriteLine("Uusi kosteus asetettu: " + uusiKosteus);
        }
    }
}
