using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus21Kauppalista
{
    internal class Tuote
    {
        //Tuoten nimi ja hinta
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public Tuote(string nimi, double hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }

        public override string ToString()
        {
            return $"{Nimi} - {Hinta} €";
        }
    }
}
