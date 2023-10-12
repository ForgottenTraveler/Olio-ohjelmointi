using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus19Hissi
{
    public class Hissisivusto
    {
        private int kerros;

        public int Kerros
        {
            get { return kerros; }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    kerros = value;
                }
                else
                {
                    Console.WriteLine("Virheellinen kerros! Käytä arvoa 1-6.");
                }
            }
        }
    }
}
   