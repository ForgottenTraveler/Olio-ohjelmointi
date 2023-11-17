using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11Opiskeliakokoelma
{
    class Opiskelija
    { //Henkilön tiedot
        private string etunimi;
        private string sukunimi;
        private string opiskelijaID;
        public string Etunimi { get => etunimi; }
        public string Sukunimi { get => sukunimi; }
        public string OpiskelijaID { get=> opiskelijaID; }
        public Opiskelija(string etunimi, string Sukunimi,string opiskelijaID)
        {
            this.etunimi = etunimi;
            this.sukunimi = Sukunimi;
            this.opiskelijaID = opiskelijaID;
        }
        public string Getdata()
        { //palauttaa tiedot
            return Etunimi + " " + Sukunimi + ". ID: " + OpiskelijaID;
        }
    }
    
    
}
