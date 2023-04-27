using Harjoitus10eläimetjarajapinnat;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
            // Luodaan muutamia eläimiä
            Kala nemo = new Kala("Nemo", 10);
            Lintu varis = new Lintu("Varis", 50);

            // Kutsutaan eri eläinten metodeja
            Console.WriteLine(nemo.GetName() + " ui nopeudella " + nemo.Swim() + " km/h.");
            Console.WriteLine(varis.GetName() + " lentää nopeudella " + varis.Fly() + " km/h.");

    }
}