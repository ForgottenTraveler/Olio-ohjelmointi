using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5laskin
{
    internal class Laskin
    {//Lakee float a ja b mitä käyttäjä on syöttänyt ja palauttaa sen
        public static float Summa (float a, float b)
        {
            return a + b;
        }
        public static float Erotus(float a, float b)
        {
            return a - b;
        }
        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }
        public static float Jako(float a, float b)
        {
            return a / b;
        }
    }
}
