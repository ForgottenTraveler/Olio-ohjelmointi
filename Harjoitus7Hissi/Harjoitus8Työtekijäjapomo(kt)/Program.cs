using Harjoitus8Työtekijäjapomo_kt_;

internal class Program
{
    private static void Main(string[] args)
    { //Näyttää henkilö
        Henkilö henkilö1 = new Työntekijä() { Nimi = "Mellukka Jokimielinen", Työpaikka = "Ohjelmoija", Palkka = 1234, viikkoTunnit = 34.2 };
        Henkilö henkilö2 = new Pomo() { Nimi = "Olli Kollasti", Työpaikka = "Toimutusjohtaja", Palkka = 4356, Bonus = 4200, Auto = "Toyota" };
        Henkilö henkilö3 = new Työntekijä() { Nimi = "Liisa Liuska", Työpaikka = "Myynnin assistentti", Palkka = 2500, viikkoTunnit = 30 };

        Console.WriteLine("Henkilö 1: " + henkilö1.Nimi + ", " + henkilö1.Työpaikka + ", " + henkilö1.Palkka + "€/kk, " + ((Työntekijä)henkilö1).viikkoTunnit + " h/vko");
        Console.WriteLine("Henkilö 2: " + henkilö2.Nimi + ", " + henkilö2.Työpaikka + ", " + henkilö2.Palkka + "€/kk, bonus " + ((Pomo)henkilö2).Bonus + "€, ajaa autolla " + ((Pomo)henkilö2).Auto);
        Console.WriteLine("Henkilö 1: " + henkilö3.Nimi + ", " + henkilö3.Työpaikka + ", " + henkilö3.Palkka + "€/kk, " + ((Työntekijä)henkilö3).viikkoTunnit + " h/vko");


    }
}