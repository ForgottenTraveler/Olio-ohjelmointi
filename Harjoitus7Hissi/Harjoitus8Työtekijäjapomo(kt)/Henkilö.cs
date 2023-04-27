using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8Työtekijäjapomo_kt_
{
    abstract class Henkilö
    {
        public string Nimi { get; set; }
        public string Työpaikka { get; set; }
        public double Palkka { get; set; }
    }
}
