﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajoneuvo
{
    class Harjoitus1Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public string Stringingtobe()
        {
            //Ajoneuvon ominaisuudet
            string Ajoneuvotiedot = "Nimi: " + Nimi + ". Nopeus: " + Nopeus.ToString() + ". Renkaat: " + Renkaat.ToString();
            return Ajoneuvotiedot;
        }
        public void Datasummonner()
        {
            //Tulostin ajoneuvon ominaisuudesta
            Console.WriteLine(Stringingtobe()+"\nVrooms");
        }
    }
}
