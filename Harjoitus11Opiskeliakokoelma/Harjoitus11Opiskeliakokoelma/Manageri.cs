using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11Opiskeliakokoelma
{
    internal class Manageri
    {
        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();
        public static void lisääopiskelija(string etunimi, string sukunimi)
        {
            bool sallittu = false;
            string opiskelijaID = "";
            while (!sallittu)
            {
                try
                {
                    Console.Write("OpiskelijaID: ");
                    opiskelijaID = Console.ReadLine();
                    sallittu = TarkistaID(opiskelijaID);
                }
                catch (OpiskelijaPoikkeus)
                {
                    
                }
               
            }
            if (sallittu)
            {
                Opiskelija.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
                Tulosviesti(string.Format("Uusi opiskelija {0} lisätty kokoelmaan.", Opiskelijat[opiskelijaID].getdata()));
            }
        }
        public static bool TarkistusID(string id)
        {
            if(Opiskelijat.ContainsKey(id))
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " ei ole uniikki, anna uusi ID");
            }
            else if (id.Length <= 4 || id.Length == 6)
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " on liian pitkä tai lyhyt, Opiskelija ID:n ituus tulee olla tasan 5");
            }
            else
            {
                return true;
            }
        }
        public static void PoistaOpiskelija(int syötettyIndex)
        {
            int i = 0;
            foreach (string avain in Opiskelijat.Keys)
            {
                if (i == syötettyIndex)
                {
                    TulostaViesti("Opiskelija " + Opiskelijat[avain].HaeData() + " poistettu kokoelmasta");
                    Opiskelijat.Remove(avain);
                    break;
                }
                i++;
            }
        }
    }
}
