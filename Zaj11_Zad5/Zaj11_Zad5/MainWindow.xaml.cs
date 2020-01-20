using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Zaj11_Zad5
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

        public class Wydział
        {
            private string _nazwa;
            public string _Nazwa
            {
                get { return _nazwa; }
                set { _nazwa = value; }
            }

            private string _rokZalozenia;
            public string _RokZalozenia
            {
                get { return _rokZalozenia; }
                set { _rokZalozenia = value; }
            }

            private string _liczbaStudentow;
            public string _LiczbaStudentow
            {
                get { return _liczbaStudentow; }
                set { _liczbaStudentow = value; }
            }

           

            public Wydział(string Nazwa, string RokZalozenia, string LiczbaStudentow)
            {
                this._Nazwa = Nazwa;
                this._RokZalozenia = RokZalozenia;
                this._LiczbaStudentow = LiczbaStudentow;

            }



        }

        class Controller
        {
            static public List<Wydział> lista = new List<Wydział>();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text) && !String.IsNullOrWhiteSpace(textBox_Copy.Text) &&
                !String.IsNullOrWhiteSpace(textBox_Copy1.Text))
            {

                if (Convert.ToInt32(textBox_Copy.Text) > 0 && Convert.ToInt32(textBox_Copy1.Text) > 0)
                {
                    Controller.lista.Add(new Wydział(textBox.Text, textBox_Copy.Text, textBox_Copy1.Text));
                }
                else
                {
                    MessageBox.Show("Rok i Liczba studentów nie mogą być ujemne lub równe 0", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

               


            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            string path = textBox1.Text;
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter textStreamWriter = new StreamWriter(path))
            {
                foreach (var VARIABLE in Controller.lista)
                {
                    textStreamWriter.WriteLine("Nazwa: {0} Rok założenia: {1} Liczba studentów {2} /n", VARIABLE._Nazwa, VARIABLE._RokZalozenia, VARIABLE._LiczbaStudentow);
                }

            }
            

    }
    }
}
