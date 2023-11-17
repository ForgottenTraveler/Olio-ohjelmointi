using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus12korttipakka_kt_
{
    class pakka
    {
        private List<Kortti> kortit;
        public pakka()
        {
            //Korttipakan asiat ja numerot.
            kortit = new List<Kortti>();
            string[] maat = { "Pata", "Hertta", "Ruutu", "Risti" };
            string[] numerot = { "1","2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            foreach (string maa in maat)
            {
                foreach (string numero in numerot)
                {
                   kortit.Add(new Kortti(maa, numero));
                }
            }
            
        }
        public void Tulostakortti()
        {
            //Tulostaa kortti
            foreach (Kortti kortti in kortit)
            {
                Console.WriteLine(kortti);
            }
        }
        public void shuffle()
        { //Sekoittaa korttia
            Random rnd = new Random();
            int n = kortit.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Kortti kortti = kortit[k];
                kortit[k] = kortit[n];
                kortit[n] = kortti;
            }
        }
    }
}
