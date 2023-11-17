using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Harjoitus26Omasovellus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> tasks;

        public MainWindow()
        {
            InitializeComponent();
            tasks = new ObservableCollection<string>();
            taskListBox.ItemsSource = tasks;
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        { //Nappula joka lisää kun käyttäjä on syöttänyt
            if (!string.IsNullOrWhiteSpace(taskTextBox.Text))
            {
                tasks.Add(taskTextBox.Text);
                taskTextBox.Clear();
            }
        }

        private void RemoveTask_Click(object sender, RoutedEventArgs e)
        { //valittu asia joka on lisätty poistetaan
            if (taskListBox.SelectedItem != null)
            {
                tasks.Remove(taskListBox.SelectedItem.ToString());
            }
        }
    }
}
