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

namespace WpfApp3
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

        private void textBox_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            int a = 0;
            int.TryParse(textBox.Text, out a);
            if (a < 0 && char.IsLetter(textBox.Text[0]))
            {
                MessageBox.Show("Błedny format danych", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                textBox_Copy.Text = (a * 4).ToString();
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            textBox_Copy.Text = string.Empty;
            textBox_Copy1.Text = string.Empty;
        }

        private void textBox_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = 0;
            int.TryParse(textBox.Text, out a);
            textBox_Copy.Text = (a*4).ToString();

        }

        private void textBox_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int a = 0;
            int.TryParse(textBox.Text, out a);
            textBox_Copy1.Text = (Math.Pow(a,2)).ToString();
        }
    }
}
