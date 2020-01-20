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

namespace WpfApp2
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
            var last = textBox_Copy1.Text.LastOrDefault();
            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox_Copy.Text) &&
                !String.IsNullOrEmpty(textBox_Copy1.Text) && (radioButton.IsChecked == true || radioButton_Copy.IsChecked == true))
            {
                if(radioButton.IsChecked == true && last % 2 == 0 || radioButton_Copy.IsChecked == true && last % 2 != 0)
                {
                    MessageBox.Show("Numer PESEL niezgodny z wybraną płcią", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    textBox_Copy1.Background = Brushes.Red;
                }
                else if (last % 2 == 0 && radioButton_Copy.IsChecked == true)
                {
                    
                    MessageBox.Show("Pomyślnie zapisano w bazie", "Powodzenie", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    textBox_Copy1.Background = Brushes.White;
                }
                else if(last % 2 != 0 && radioButton.IsChecked == true)
                {
                    MessageBox.Show("Pomyślnie zapisano w bazie", "Powodzenie", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    textBox_Copy1.Background = Brushes.White;
                }

            }
            else if(radioButton.IsChecked == false && radioButton_Copy.IsEnabled == false)
            {
                MessageBox.Show("Znacz płeć", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
