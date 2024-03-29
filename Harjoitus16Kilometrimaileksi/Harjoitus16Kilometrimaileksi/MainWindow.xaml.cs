﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus16Kilometrimaileksi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void VaihdaKmMl(object sender, RoutedEventArgs e)
        { //Käyttäjä antaa numero Float 1
            float Luku1;
            //Result laskee float 1 annettu luku ja vaihtaa sen annettu lukua KmMl:lään
            bool result = float.TryParse(Tekstiruutu.Text, out Luku1);
            if (result)
            {
                string Converttext = Luku1 + " Kilometri on yhtä kuin " + KilometriMileen(Luku1).ToString() + " Metriksi";
                PäivitäTeksti(Converttext);
            }
            else
            {
                PäivitäTeksti("Teksti kenttä ei saa sisältää muuta kuin Numeroita.");
            }
        }

        private void VaihdaMlKm(object sender, RoutedEventArgs e)
        {
            float Luku1;
            //Tämä result on sama kuin ylhäällä mutta vaihdaa sen MlKm
            bool result = float.TryParse(Tekstiruutu.Text, out Luku1);
            if (result)
            {
                string Converttext = Luku1 + " metriä on yhtä kuin " + MetriKilometriin(Luku1).ToString() + " kiloMetriksi";
                PäivitäTeksti(Converttext);
            }
            else
            {
                PäivitäTeksti("Teksti kenttä ei saa sisältää muuta kuin Numeroita.");
            }
        }
        private void PäivitäTeksti(string Teksti)
        {
            //Tämä päivittää kun nappia onjo painettu
            Tekstiruutu1.Text = Teksti;
        }
        private static float KilometriMileen(float a)
        { //Lasku palautus
            float conversion = 0.62137f;
            return a * conversion;
        }
        private static float MetriKilometriin(float a)
        { //Lasku palautus
            float Conversion = 1.609344f;
            return a * Conversion;
        }
    }
}
