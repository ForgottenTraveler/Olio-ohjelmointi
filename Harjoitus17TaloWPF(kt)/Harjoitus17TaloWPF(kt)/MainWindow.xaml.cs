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

namespace Harjoitus17TaloWPF_kt_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float lämpötila;
        bool keittiöValot;
        bool olohuoneenValot;
        bool oviLukossa;

        public MainWindow()
        {
            InitializeComponent();
            Textblocko4.Text = "0℃";
        }
        public float Kasvatus;
        public float Vähennys;

        private void KitchenlightOn(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = "Keittiö Valo: On";
        }

        private void KitchenlightOff(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = "Keittiö Valo: Off";
        }

        private void OloHuoneIsOn(object sender, RoutedEventArgs e)
        {
            TextBlock2.Text = "OloHuone Valo: On";
        }

        private void OloHuoneisOff(object sender, RoutedEventArgs e)
        {
            TextBlock2.Text = "OloHuone Valo: Off";
        }

        private void Ovi_Lukossa(object sender, RoutedEventArgs e)
        {
            TextBlock3.Text = "Ovi Lukossa";
        }

        private void Ovi_Auki(object sender, RoutedEventArgs e)
        {
            TextBlock3.Text = "Ovi Avattu";
        }

        private void Lisää_onClick(object sender, RoutedEventArgs e)
        {// Lisää Lämpötilaa
            Kasvatus +=1.0f;
            Textblocko4.Text = Kasvatus.ToString();
        }

        private void Vähennys_OnClick(object sender, RoutedEventArgs e)
        {// vähentää lämpötila
            Vähennys -= 1.0f;
            Textblocko4.Text = Vähennys.ToString();
        }
    }
}
