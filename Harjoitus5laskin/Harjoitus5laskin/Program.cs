﻿using Harjoitus5laskin;

internal class Program
{
    private static void Main(string[] args)
    {
        float a = 3.5f;
        float b = 1.5f;
        
        float summa = Laskin.Summa(a, b);
        float Erotus = Laskin.Erotus(a, b);
        float Kertolasku = Laskin.Kertolasku(a, b);
        float jako = Laskin.Jako(a, b);

        Console.WriteLine("Numeroiden " + a +" ja " +b +": ");
        Console.WriteLine("Summa: "+summa);
        Console.WriteLine("Erotus: " +Erotus);
        Console.WriteLine("Kertolasku: " + Kertolasku);
        Console.WriteLine("Jako: " + jako);
    }
}