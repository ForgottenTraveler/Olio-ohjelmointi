using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus2opiskelija
{
    internal class Opiskelija
    {
        public string Nimi { get; set; }
        public string OpiskelijaID { get; set; }
        public int Opintopisteet { get; set; }

        public Opiskelija(string _nimi, string _OpiskelijaID, int _Opintopisteet)
        {
            Nimi = _nimi;
            OpiskelijaID = _OpiskelijaID;
            Opintopisteet= _Opintopisteet;
        }
        
        public void Datatulostin()
        {
            //Tulostaa opiskelijan ominaisuudet
            string opiskelijatiedot = "nimi: " + Nimi + ". OpiskelijaID: " + OpiskelijaID + ". Opintopisteet: " ;
            Console.Write(opiskelijatiedot);
        }
        public void Opintopisteenmuokkaaja() 
        {
            //Opintopistemuokkaus tulostin
            Random RandPiste = new Random();
            Opintopisteet = RandPiste.Next(5, 25);
            Console.WriteLine(Opintopisteet);
        }   
    }
}
