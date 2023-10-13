using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus24lottoWPF
{
    internal class Lotto
    {
        private Random random = new Random();
        public int[] ArvoRivi(int numeroidenMaara, int alaraja, int ylaraja)
        {
            return Enumerable.Range(alaraja, ylaraja - alaraja + 1)
                .OrderBy(x => random.Next())
                .Take(numeroidenMaara)
                .ToArray();
        }
        
        public string TulostaRivi(int[] rivi)
        {//tulostaa rivin asiat
            return string.Join(", ", rivi);
        }
    }
}
