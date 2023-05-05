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

namespace Harjoitus15Autolaskuri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TekstiRuutu.Text = "0";
            TekstiRuutuKaksi.Text = "0";
        }
        public int Kasvatus;
        public int Kasvatusrekka;
        private void VaihdaClick(object sender, RoutedEventArgs e)
        {
            Kasvatus++;
            TekstiRuutu.Text = Kasvatus.ToString();
        }

        private void VaihdaRekka(object sender, RoutedEventArgs e)
        {
            Kasvatusrekka++;
            TekstiRuutuKaksi.Text = Kasvatusrekka.ToString();
        }
    }
}
