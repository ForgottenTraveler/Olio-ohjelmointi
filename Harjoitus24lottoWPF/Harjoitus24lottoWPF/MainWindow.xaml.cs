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

namespace Harjoitus24lottoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Lotto lotto = new Lotto();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTulosta_Click(object sender, RoutedEventArgs e)
        {
            txtArvotutRivit.Text = ""; // Tyhjentää ensin

            if (int.TryParse(txtMontaRivia.Text, out int montaRivia))
            {
                for (int i = 0; i < montaRivia; i++)
                {
                    int[] rivi = ArvoRivi();
                    txtArvotutRivit.Text += $"{lotto.TulostaRivi(rivi)}\n";
                }
            }
            else
            {// näyttä messagebox josta kun käyttäjä ei laitanny sopiva numero riville.
                MessageBox.Show("Syötä kelvollinen numero riveille.");
            }
        }
        private int[] ArvoRivi()
        {
            int alaraja = 1;
            int ylaraja = 1;
            switch (cmbPelivalinta.SelectedIndex)
            {
                case 0: 
                    ylaraja = 40;
                    break;
                case 1: 
                    ylaraja = 48;
                    break;
                case 2: 
                    ylaraja = 50;
                    break;
            }
            return lotto.ArvoRivi(7, alaraja, ylaraja);
        }
        private void btnTyhjenna_Click(object sender, RoutedEventArgs e)
        {
            txtArvotutRivit.Text = "";
        }
        private void btnViikonArvonta_Click(object sender, RoutedEventArgs e)
        {
            txtArvotutRivit.Text = "Viikon Arvonta:\n";
            int[] rivi = ArvoRivi();
            txtArvotutRivit.Text += $"{lotto.TulostaRivi(rivi)}\n";
            // Tarkista voitot ja muut lisätoiminnot voivat tulla tähän
        }
    }
}
