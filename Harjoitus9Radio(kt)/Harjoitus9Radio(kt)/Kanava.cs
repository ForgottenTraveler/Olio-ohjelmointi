using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9Radio_kt_
{
    internal class Kanava
    {
        public string Nimi { get; set; }
        public double Taajuus { get; set; }

        public Kanava(string nimi, double taajuus)
        {
            Nimi = nimi;
            Taajuus = taajuus;
        }
    }
}
