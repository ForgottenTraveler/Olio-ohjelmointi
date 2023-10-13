using System;
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

namespace Harjoitus21Kauppalista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Tuote> ostoskori = new List<Tuote>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOsta_Click(object sender, RoutedEventArgs e)
        {
            // CheckBoxit jossa myös lisätään sen ostoskorille
            foreach (var control in StockPanel.Children)
            {
                if (control is CheckBox checkBox && checkBox.IsChecked == true)
                {
                    // Lisätään valittu tuote ostoskoriin
                    switch (checkBox.Name)
                    {
                        case "chkMaito":
                            ostoskori.Add(new Tuote("Maito", 1.5));
                            break;
                        case "chkLeipä":
                            ostoskori.Add(new Tuote("Leipä", 2.0));
                            break;
                        case "chkJuusto":
                            ostoskori.Add(new Tuote("Juusto", 3.0));
                            break;
                        case "chkKahvi":
                            ostoskori.Add(new Tuote("Kahvi", 5.0));
                            break;
                        case "chkSuklaa":
                            ostoskori.Add(new Tuote("Suklaa", 2.5));
                            break;
                    }
                    // poistaa CheckBox valinta
                    checkBox.IsChecked = false;
                }
            }
            // Näyttää ostoskorin sisältö
            ShowOstoskori();
        }
        private void ShowOstoskori()
        {
            // messagebox näyttäminen
            MessageBox.Show("Ostoskori:\n\n" + string.Join("\n", ostoskori));
        }
    }
}
