using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zaj11_zad2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text) && textBox.Text != "0" && Convert.ToInt32(textBox.Text) > 0)
            {
                var wynik = Fibonacci.ObliczNtyElement(Convert.ToInt32(textBox.Text));
                MessageBox.Show($"{wynik.ToString()}", "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Wpisz dane do okna tekstowego", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Fibonacci.PodajInformacje()}", "Informacje", MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text) && textBox.Text != "0" && Convert.ToInt32(textBox.Text) > 0)
            {
                byte output;
                byte.TryParse(textBox.Text, out output);
                var wynik = Fibonacci.ObliczSumeNelementów(output);
                MessageBox.Show($"{wynik.ToString()}", "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Wpisz dane do okna tekstowego", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
