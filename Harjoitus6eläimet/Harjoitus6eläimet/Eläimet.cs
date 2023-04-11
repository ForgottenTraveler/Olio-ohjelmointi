using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6eläimet
{
    internal class Eläimet 
    {
        public int Maxikä;
        public abstract int Maxikä { get; set; }
        private string Nimi;
        public string Nimi { get; set; }
        private int Ikä;
        public virtual int Ikä
        {
            get { return Ikä; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Annettu ikä on pienempi kuin 0, Eläimen ikä on asetettu 0");
                    value = 0;
                }
                else if (value > Maxikä)
                {
                    Console.WriteLine("Annettu ikä ylittää {0}. Eläimen iäksi asetettu {1}",Maxikä, Maxikä - 1);
                    value = Maxikä - 1;
                }

                Ikä = value;
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
        public abstract ääntele();
    }
}
