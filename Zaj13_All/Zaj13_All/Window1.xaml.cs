using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zaj13_All
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

        class Los
        {
            public static int Liczba()
            {
                Random r1 = new Random();
                var wynik = r1.Next(1, 4);
                return wynik;
            }
        }

        class NazwaPrzycisku
        {
            public static MessageBoxResult Nazwa(string value)
            {
                MessageBoxResult w1 = MessageBoxResult.None;
                var los = Los.Liczba();
                if (los == 1 && value == "p1")
                {
                    w1 = MessageBox.Show($"wylosowano liczbę {los} - bomba jest ukryta pod przyciskiem {value}", "Bomba",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (los == 2 && value == "p2")
                {
                    w1 = MessageBox.Show($"wylosowano liczbę {los} - bomba jest ukryta pod przyciskiem {value}", "Bomba",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if(los == 3 && value == "p3")
                {
                    w1 = MessageBox.Show($"wylosowano liczbę {los} - bomba jest ukryta pod przyciskiem {value}", "Bomba",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

                return w1;
            }
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            NazwaPrzycisku.Nazwa("p1");

        }


        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

            NazwaPrzycisku.Nazwa("p2");

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {

            NazwaPrzycisku.Nazwa("p3");

        }
    }
}
