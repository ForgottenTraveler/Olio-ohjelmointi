using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace Harjoitus20OpiskelijaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Opiskelija> opiskelijat = new List<Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            // Luodaan uusi opiskelija
            Opiskelija uusiOpiskelija = new Opiskelija
            {
                Etunimi = txtEtunimi.Text,
                Sukunimi = txtSukunimi.Text,
                OpiskelijaID = int.Parse(txtOpiskelijaID.Text),
                Sähköposti = txtSähköposti.Text,
                Puhelinnumero = txtPuhelinnumero.Text
            };

            // Lisätään opiskelija listaan
            opiskelijat.Add(uusiOpiskelija);

            // Näytetään opiskelijat TextBlockissa
            ShowOpiskelijat();
        }

        private void ShowOpiskelijat()
        {
            StockPanel.Children.Clear();
            foreach (var opiskelija in opiskelijat)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = $"Etunimi: {opiskelija.Etunimi}, Sukunimi: {opiskelija.Sukunimi}, ID: {opiskelija.OpiskelijaID}, Sähköposti: {opiskelija.Sähköposti}, Puhelinnumero: {opiskelija.Puhelinnumero}",
                    Margin = new Thickness(0, 0, 0, 5)
                };
                StockPanel.Children.Add(textBlock);
            }
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            // Tallennetaan opiskelijat tiedostoon
            using (FileStream fs = new FileStream("opiskelijat.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, opiskelijat);
            }
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            // Yritetään ladata opiskelijat tiedostosta
            try
            {
                using (FileStream fs = new FileStream("opiskelijat.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    opiskelijat = (List<Opiskelija>)formatter.Deserialize(fs);
                    ShowOpiskelijat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}");
            }
        }
    }
}
