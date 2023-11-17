using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6eläimet
{
    abstract class Eläimet 
    { //eläimen tiedot
        public int maxIkä;
        public abstract int MaxIkä { get; set; }
        private string nimi;
        public string Nimi { get; set; }
        private int ikä;
        public virtual int Ikä
        {
            get { return ikä; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Annettu ikä on pienempi kuin 0, Eläimen ikä asetettu 0");
                    value = 0;
                }
                else if (value > MaxIkä)
                {
                    Console.WriteLine("Annettu ikä ylittää {0}. Eläimen iäksi asetettu {1}", MaxIkä, MaxIkä - 1);
                    value = MaxIkä - 1;
                }

                ikä = value;
            }
        }
        private static int intanssi = 0;

        public Eläimet()
        {
            intanssi++;
        }
        public static void kuinkamonta()
        {
            Console.WriteLine("Eläintä on yhteensä luotu " + intanssi + " kappaletta");
        }
        public abstract void ääntele();
    }
}
