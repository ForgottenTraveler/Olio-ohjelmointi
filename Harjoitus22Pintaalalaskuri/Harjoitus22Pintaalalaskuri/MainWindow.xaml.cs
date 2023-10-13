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

namespace Harjoitus22Pintaalalaskuri
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
        private void btnLaske_Click(object sender, RoutedEventArgs e)
        {
            // Tarkistaa että leveys, korkeus ja karmi ovat toimivia lukuja
            if (!double.TryParse(txtLeveys.Text, out double leveys) ||
                !double.TryParse(txtKorkeus.Text, out double korkeus) ||
                !double.TryParse(txtKarmi.Text, out double karmi))
            {
                MessageBox.Show("Anna kelvolliset numerot.");
                return;
            }

            // Laskee pinta-alat ja piiri
            double ikkunaPintaAla = leveys * korkeus / 100; 
            double lasiPintaAla = (leveys - 2 * karmi) * (korkeus - 2 * karmi) / 100; 
            double karmiPiiri = 2 * (leveys + korkeus) / 100; 

            // Päivitää näkymät
            DrawIkkuna(leveys, korkeus, karmi);
            ShowResults(ikkunaPintaAla, lasiPintaAla, karmiPiiri);
        }

        private void DrawIkkuna(double leveys, double korkeus, double karmi)
        {
            canvas.Children.Clear();

            // Piirtää ikkuna
            Rectangle ikkuna = new Rectangle
            {
                Width = leveys,
                Height = korkeus,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            canvas.Children.Add(ikkuna);

            // Piitärä lasi
            Rectangle lasi = new Rectangle
            {
                Width = leveys - 2 * karmi,
                Height = korkeus - 2 * karmi,
                Stroke = Brushes.Blue,
                StrokeThickness = 2,
                Margin = new Thickness(karmi)
            };

            canvas.Children.Add(lasi);
        }

        private void ShowResults(double ikkunaPintaAla, double lasiPintaAla, double karmiPiiri)
        {
            //Näyttää messagebox
            MessageBox.Show($"Ikkunan pinta-ala: {ikkunaPintaAla} cm^2\n" +
                            $"Lasin pinta-ala: {lasiPintaAla} cm^2\n" +
                            $"Karmin piiri: {karmiPiiri} cm");
        }
    }
}
