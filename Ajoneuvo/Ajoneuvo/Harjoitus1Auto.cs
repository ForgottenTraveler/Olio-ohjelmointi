﻿using Ajoneuvo;

class Harjoitsu1Auto
{
    static void Main(string[] args)
    {
        
        Harjoitus1Ajoneuvo AutoOlio = new Harjoitus1Ajoneuvo();

        AutoOlio.Nimi = "Toyota";
        AutoOlio.Nopeus = 50;
        AutoOlio.Renkaat = 4;
        //Tulostaa ajoneuvon ominaisuudet konsoliin
        AutoOlio.Datasummonner();
    }
}
