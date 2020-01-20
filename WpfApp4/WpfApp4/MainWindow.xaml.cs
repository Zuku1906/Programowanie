using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

namespace WpfApp4
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

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            button.Content = "Hello world!";
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (button.Content is "Hello world!")
            {
                button.Content = "Przywitanie";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString(), "Informacja o czasie", MessageBoxButton.OK, MessageBoxImage.Information );
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double a = 0.0;
            double b = 0.0;
            if (!String.IsNullOrWhiteSpace(textBox.Text) && !String.IsNullOrWhiteSpace(textBox_Copy.Text))
            {
                if (textBox_Copy.Text is "0")
                {
                    MessageBox.Show("Nie da się dzielić przez zero cholero!!!!", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    double.TryParse(textBox.Text, out a);
                    double.TryParse(textBox_Copy.Text, out b);
                    var wynik = (a / b);
                    MessageBox.Show($"Wynik z dzielenia to : {wynik}", "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1_Copy.Text) &&
                !String.IsNullOrWhiteSpace(textBox1_Copy1.Text))
            {
                var index = 0;
                var length = textBox1_Copy1.Text.Length;
                index = length - 2;
                if (textBox1_Copy1.Text[index] % 2 == 0 && radioButton_Copy.IsChecked==true)
                {
                    MessageBox.Show("Pomyślnie wysłano do bazy", "Info", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                else if (textBox1_Copy1.Text[index] % 2 != 0 && radioButton.IsChecked == true)
                {
                    MessageBox.Show("Pomyślnie wysłano do bazy", "Info", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Błędny PESEL", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    textBox1_Copy1.Background = Brushes.Red;
                }

                



            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
