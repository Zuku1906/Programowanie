using System;
using System.Collections.Generic;
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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            textBox_Copy4.IsEnabled = false;
        }

        interface IPacjent
        {
            string Imie { get; set; }
            string Nazwisko { get; set; }
            byte Wiek { get; set; }
            byte Waga { get; set; }
            byte Wzrost { get; set; }
            float ObliczBMI();
        }

        class Lista : IPacjent
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public byte Wiek { get; set; }
            public byte Waga { get; set; }
            public byte Wzrost { get; set; }

            public Lista(string imie, string nazwisko, byte wiek, byte waga, byte wzrost)
            {
                this.Imie = imie;
                this.Nazwisko = nazwisko;
                this.Wiek = wiek;
                this.Waga = waga;
                this.Wzrost = wzrost;
            }

            public float ObliczBMI()
            {
                float bmi = (Waga / (Wzrost * Wzrost));
                return bmi;
            }

        }


        private void textBox_Copy2_TextChanged(object sender, TextChangedEventArgs e)
        {
            byte waga = 0;
            byte.TryParse(textBox_Copy2.Text, out waga);
        }

        private void textBox_Copy3_TextChanged(object sender, TextChangedEventArgs e)
        {
            byte wzrost = 0;
            byte.TryParse(textBox_Copy3.Text, out wzrost);

        }

    }
}
