using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8Työtekijäjapomo_kt_
{
    internal class Pomo : Henkilö
    {//Johtajan tiedot
        private static bool johtajaOnolemassa = false;
        private double bonus;
        private string auto;

        public double Bonus
        {
            get { return bonus; }
            set 
            {
                if (!johtajaOnolemassa)
                {
                    bonus = value;
                }
                else
                {
                    Console.WriteLine("Johataja on olemassa, et voi luoda uusi johtaja.");
                }
            }
        }
        public string Auto
        {
            get { return auto; }
            set { auto = value; }
        }
        public Pomo()
        {
            if (!johtajaOnolemassa)
            {
                johtajaOnolemassa = true;
            }
            else
            {
                Console.WriteLine("Johtaja on olemassa, et voi luoda uusi johtaja.");
            }
        }
    }
}
