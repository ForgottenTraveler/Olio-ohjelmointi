using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6eläimet
{
    internal class Kissa : Eläimet
    {
        public override int Maxikä { get => Maxikä; set => Maxikä = value; }
        private static int intanssi = 0;
        public Kissa(string _nimi, int _ikä)
        {
            Maxikä = 30;

            Nimi = _nimi;
            Ikä = _ikä;

            intanssi++;

            Console.WriteLine("Kissa luotu nimeltään: " + _nimi);
        }
        public static new void kuinkamonta()
        {
            Console.WriteLine("Kissoja on yhteensä luotu " + intanssi + " kappaletta");
        }
        public override void ääntele()
        {
            Console.WriteLine(Nimi + " Sanoo: Meow meow");
        }
    }
}
