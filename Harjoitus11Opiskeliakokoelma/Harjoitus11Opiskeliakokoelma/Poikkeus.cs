using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11Opiskeliakokoelma
{
    class Poikkeus : Exception
    {
        public Poikkeus(string message) : base(message)
        { //Poikkeus paikka
            Console.WriteLine();
            Console.WriteLine("----Error----");
            Console.WriteLine("Error: " + message);
            Console.WriteLine("----Error----");
            Console.WriteLine();
        }
    }
}
