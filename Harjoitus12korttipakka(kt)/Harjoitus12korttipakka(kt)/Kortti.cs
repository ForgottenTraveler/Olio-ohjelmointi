using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12korttipakka_kt_
{
    class Kortti
    {
        public string Maa { get; set; }
        public string Numero { get; set; }

        public Kortti(string maa, string numero)
        {
            Maa = maa;
            Numero = numero;
        }

        public override string ToString() 
        {
            return  "Kortti on " + Maa + " - " + Numero;
        }


    }
}
