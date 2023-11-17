using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7Hissi
{
    internal class Hissi
    { //hissin tiedot
        private int kerros;
        private int minkerros;
        private int maxkerros;

        public int Kerros
        {
            set 
            {
                if (value < minkerros)
                {// Jos käyttäjää ei anna kunnon koemntoa tämä viesti tulee
                    ErrorHelp.Kirjoitaserror("00001f; Virheellinen kerros annettu. Annettu arvo " + value + " on pienempi kuin " + minkerros);
                }
                else if (value > maxkerros)
                {
                    ErrorHelp.Kirjoitaserror("00001f; Virheellinen kerros annettu. Annettu arvo " + value + " on suurempi kuin " + maxkerros);
                }
                else
                {
                    kerros = value;
                }
            }
        }
        public Hissi(int _minkerros, int _maxkerros)
        { 
            minkerros = _minkerros;
            maxkerros = _maxkerros;
        }
        public void tulostanykykerros()
        {//Tulostaa missä kerroksessä henkilö on
            Console.WriteLine("Nykyinen kerros on " + kerros);
        }
        public string PalautusMinMax()
        {
            return minkerros.ToString() + "-" + maxkerros.ToString();
        }
    }
}
