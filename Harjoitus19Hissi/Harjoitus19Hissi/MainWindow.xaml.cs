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

namespace Harjoitus19Hissi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hissisivusto hissi = new Hissisivusto();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Siirry_Click(object sender, RoutedEventArgs e)
        {
            // nappula joka antaa messagebox.
            if (int.TryParse(txtKerros.Text, out int syotettyKerros))
            {
                // kun on latettu numeroa ja painanut nappulan tulee messagebox viesti
                hissi.Kerros = syotettyKerros;
                MessageBox.Show($"Olet kerroksessa {hissi.Kerros}");
            }
            else
            { 
                // viesti josta käyttäjä ei ole laitanut mitään. on vain painanut nappia.
                MessageBox.Show("Virheellinen syöte! Anna kokonaisluku.");
            }
        }
    }
}
