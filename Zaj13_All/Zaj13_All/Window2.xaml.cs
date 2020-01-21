using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        class CzytaniePliku
        {
            public static List<string> Plik()
            {
                StreamReader sr = new StreamReader(@"C:\Users\drago\Desktop\zaj12_studenci.txt");
                string line = string.Empty;
                List<string> dane = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] returnedArray = line.Split("\t");
                    for (int i = 0; i < returnedArray.Length; i++)
                    {
                        dane.Add(returnedArray[i]);
                    }
                    

                }
                sr.Close();
                return dane;
            }

            public static void Studenci(string textBox)
            {
                
                List<string> dane = CzytaniePliku.Plik();
                Window3 w3 = new Window3();
                foreach (var VARIABLE in dane)
                {
                    if (VARIABLE == textBox)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            w3.label.Content += dane[i];
                            w3.label.Content += " ";
                        }
                    }
                    
                }
                if (w3.label.Content == string.Empty)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    w3.Show();
                }

                

            }

        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(textBox.Text))
                {
                    CzytaniePliku.Plik();
                    CzytaniePliku.Studenci(textBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    
    }
}
