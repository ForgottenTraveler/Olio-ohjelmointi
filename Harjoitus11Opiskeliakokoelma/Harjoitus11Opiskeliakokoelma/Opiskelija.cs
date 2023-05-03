using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus11Opiskeliakokoelma
{
    internal class Opiskelija
    {
        private string etunimi;
        private string sukunimi;
        private string OpiskelijaID;
        public string Etunimi { get => etunimi; }
        public string Sukunimi { get => sukunimi; }
        public string opiskelijaID { get=> OpiskelijaID; }
        public Opiskelija(string _etunimi, string Sukunimi,string _opiskelijaID)
        {
            this.etunimi = _etunimi;
            this.sukunimi = Sukunimi;
            this.OpiskelijaID = _opiskelijaID;
        }
    }
    
    public string getdata()
    {
        return Etunimi + " " + Sukunimi + ". ID: " + opiskelijaId;
    }
}
