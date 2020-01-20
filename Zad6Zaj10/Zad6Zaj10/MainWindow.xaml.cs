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

namespace Zad6Zaj10
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

        class Global
        {
            public static int score;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Global.score = Global.score + 1;
            button.Content = Global.score.ToString();

            if (Global.score == 100)
            {
                MessageBox.Show("Gratulacje kliknąłeś 100 razy zjebie", "HAHA BECZKA", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }


        }
    }
}
