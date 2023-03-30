using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajoneuvo
{
    class koira
    {
        public string nimi { get; set; }
        public string Rotu { get; set;}
        public int Ikä { get; set; }
        public String väri { get; set; }
        public float Paino { get; set; }

        public koira(string _nimi, string _rotu, int _ikä, string _väri, float _paino) 
        { 
            nimi = _nimi;
            Rotu = _rotu;
            Ikä = _ikä;
            väri = _väri;
            Paino = _paino;
        }
        public string HaeTiedot()
        {
            string KoiranTiedot = "Nimi: " + nimi + ". Rotu: " + Rotu + ". Ikä: " + Ikä.ToString() + ". Väri: " + väri + ". Paino: " + Paino.ToString();
            return KoiranTiedot;
        }

        public void Hauku()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
