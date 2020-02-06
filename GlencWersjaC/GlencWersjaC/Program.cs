using System;
using System.Collections.Generic;

namespace GlencWersjaC
{
    class Program
    {
        class Księgarnia
        {
            public bool SprawdzISBN(string isbn, int rokWydania)
            {
                bool test = false;

                if (isbn.Length == 9 && rokWydania < 2007 || isbn.Length == 13 && rokWydania >= 2007)
                {
                    test = true;
                }

                return test;
            }

            public void IleDoDniaKsiegarza()
            {
                DateTime dzienKsiegarza = new DateTime(DateTime.Now.Year, 12,13);
                
                Console.WriteLine("Do dnia pedała zostało: " + (dzienKsiegarza - DateTime.Now).Days);
            }

            public void JakWypadamNaTleInnych(byte liczbaPrzeczytanychKsiazek)
            {
                if (liczbaPrzeczytanychKsiazek > 2.2)
                {
                    Console.WriteLine("Przeczytałem o {0} więcej książek niż przeciętny polakens", liczbaPrzeczytanychKsiazek - 2.2);
                }
                else if (liczbaPrzeczytanychKsiazek < 2.2)
                {
                    Console.WriteLine("Przecyztałeś o {0} mniej książek niż przeciętny polakens", 2.2 - liczbaPrzeczytanychKsiazek);
                }
            }


        }



        static void Main(string[] args)
        {
            //Samochód f1=new Samochód("Mazda", "Czerwony", 100, false, 1999);
            //f1.ZatrzymajSamochód();
            //f1.UruchomSamochod();
            //f1.ZatrzymajSamochód();
            //Console.ReadKey();
           //Dokument d1 = new Dokument(500, new DateTime(2020, 02, 05));
           // Dokument d2 = new Dokument(500, new DateTime(2020, 02, 08));
           // Dokument d3 = d1 + d2;
           // d3.WyswietlDaneDokumentu();
           
           //Dictionary<Dokument, Osoba> slownDictionary = new Dictionary<Dokument, Osoba>();
           //Random rng = new Random();
           //int x = rng.Next(1, 4);
           //for (int i = 0; i < x; i++)
           //{
           //    Console.WriteLine("Numer dokumentu: " + (i+1));
           //    Console.WriteLine("Podaj liczbe stron");
           //    int liczbaStronUser = 0;
           //    int.TryParse(Console.ReadLine(), out liczbaStronUser);
           //    Console.WriteLine("Podaj date utworzenia dokumentu");
           //    DateTime dataUser;
           //    DateTime.TryParse(Console.ReadLine(), out dataUser);
           //    Dokument dokumentyUsera = new Dokument(liczbaStronUser, dataUser);
           //    Console.WriteLine("Osoba numer: " + (i+1));
           //    Console.WriteLine("Podaj imie");
           //    string inputImie = Console.ReadLine();
           //    Console.WriteLine("Podaj nazwisko");
           //    string inputNazwisko = Console.ReadLine();
           //    Osoba User = new Osoba(inputImie, inputNazwisko);
           //    slownDictionary.Add(dokumentyUsera, User);

           //}

           //foreach (var VARIABLE in slownDictionary)
           //{
           //    VARIABLE.Key.WyswietlDaneDokumentu();
           //    VARIABLE.Value.WyswietlDaneOsoby();
           //}
           Księgarnia X = new Księgarnia();
           X.SprawdzISBN("5", 2006);
           
           X.JakWypadamNaTleInnych(3);
           X.JakWypadamNaTleInnych(1);
           X.IleDoDniaKsiegarza();
           Console.ReadKey();

        }
    }
}
