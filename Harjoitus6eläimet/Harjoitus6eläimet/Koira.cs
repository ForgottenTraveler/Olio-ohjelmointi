using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6eläimet
{
    internal class Koira : Eläimet
    {
        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }
        private static int intanssi = 0;
        public Koira(string _nimi, int _ikä) 
        {
            MaxIkä = 25;

            Nimi = _nimi;
            Ikä = _ikä;

            intanssi++;

            Console.WriteLine("Koira luotu nimeltään: " + _nimi);
        }
        public static new void kuinkamonta()
        {
            Console.WriteLine("Koiria on yhteensä luotu " + intanssi + " kappaletta");
        }
        public override void ääntele()
        {
            Console.WriteLine(Nimi + " Sanoo: woof woof");
        }
    }
}
