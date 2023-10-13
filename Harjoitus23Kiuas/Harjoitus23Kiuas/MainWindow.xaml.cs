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

namespace Harjoitus23Kiuas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int lampotila = 60;
        private int kosteus = 50;
        public MainWindow()
        {
            InitializeComponent();
            UpdateTextBlocks();
        }
        private void btnLisaaLampotila_Click(object sender, RoutedEventArgs e)
        {
            //Lisää lämpötila
            if (lampotila < 120)
            {
                lampotila++;
                UpdateTextBlocks();
            }
        }
        private void btnVahennaLampotila_Click(object sender, RoutedEventArgs e)
        { //Vähentää lämpötila
            if (lampotila > 0)
            {
                lampotila--;
                UpdateTextBlocks();
            }
        }
        private void btnLisaaKosteus_Click(object sender, RoutedEventArgs e)
        {// lisää kosteusta
            if (kosteus < 100)
            {
                kosteus++;
                UpdateTextBlocks();
            }
        }
        private void btnVahennaKosteus_Click(object sender, RoutedEventArgs e)
        {//vähentää kosteusta
            if (kosteus > 0)
            {
                kosteus--;
                UpdateTextBlocks();
            }
        }
        private void UpdateTextBlocks()
        {// päivittää lämpötila ja kosteus tekstit
            txtLampotila.Text = lampotila.ToString();
            txtKosteus.Text = kosteus.ToString();
        }
    }
}
