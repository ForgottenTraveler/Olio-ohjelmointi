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

namespace Harjoitus18LaskinWPF_kt_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EkaNumero.Text = "";
            ToinenNumero.Text = "";
        }

        private void Summa_onClick(object sender, RoutedEventArgs e)
        {// luku1 ja luku2 missä henkilö kirjoittaa numeron.
            float luku1 = float.Parse(EkaNumero.Text);
            float luku2 = float.Parse(ToinenNumero.Text);
            //Result laskee luku1 ja luku2 yhdeen.
            float Result = (luku1 + luku2);
            //Result jälkeen se näytetään tulos textblockiin. sama juttu muillekin.
            TextBlock1.Text = Result.ToString();
        }

        private void Erotus_onClick(object sender, RoutedEventArgs e)
        {
            float luku1 = float.Parse(EkaNumero.Text);
            float luku2 = float.Parse(ToinenNumero.Text);
            float Result = (luku1 - luku2);
            TextBlock2.Text = Result.ToString();
        }

        private void KertoLasku_onclick(object sender, RoutedEventArgs e)
        {
            float luku1 = float.Parse(EkaNumero.Text);
            float luku2 = float.Parse(ToinenNumero.Text);
            float Result = (luku1 * luku2);
            TextBlock3.Text = Result.ToString();
        }

        private void JakoLasku_onclick(object sender, RoutedEventArgs e)
        {
            float luku1 = float.Parse(EkaNumero.Text);
            float luku2 = float.Parse(ToinenNumero.Text);
            float Result = (luku1 / luku2);
            TextBlock4.Text = Result.ToString();
        }
    }
}
