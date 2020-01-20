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

namespace WpfApp1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double a = 0.0;
            double b = 0.0;
            if (!String.IsNullOrWhiteSpace(TextBox.Text) && !String.IsNullOrWhiteSpace(textBox_Copy.Text))
            {
                double.TryParse(TextBox.Text, out a);
                double.TryParse(textBox_Copy.Text, out b);
                if (b != 0)
                {
                    var wynik = (a / b);
                    MessageBox.Show($"Wynik:{wynik}", "Wynik dzielenia", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Nie można dzielić przez zero", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Uzupełnij pola", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
