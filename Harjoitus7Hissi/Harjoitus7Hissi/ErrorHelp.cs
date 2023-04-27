using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7Hissi
{
    internal class ErrorHelp
    {
        public static void Kirjoitaserror(string virhe)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("ERROR MESSAGE: " + virhe);
            Console.WriteLine("-------------");
        }
    }
}
