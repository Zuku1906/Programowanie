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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox_Copy.IsEnabled = false;
            textBox_Copy1.IsEnabled = false;
        }

        private void textBox_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double n = 0;
            double.TryParse(textBox.Text, out n);
            if (n > 0)
            {
                textBox_Copy.Text = (n * 4).ToString();
                textBox_Copy1.Text = (n * n).ToString();
            }
            else if(n < 0)
            {
                MessageBox.Show("Podana wartość musi być większa od zera!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            else
            {
                if (textBox.Text != "-" && textBox.Text != string.Empty)
                {
                    MessageBox.Show("Podana wartość nie może być string", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            textBox_Copy.Text = string.Empty;
            textBox_Copy1.Text = string.Empty;
        }
    }
}
