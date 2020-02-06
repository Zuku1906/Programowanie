using System;
using System.Collections.Generic;
using System.Text;

namespace GlencWersjaC
{
    class Samochód
    {
        private string model = string.Empty;
        private string kolor = string.Empty;
        private int przebieg = 0;
        private bool czyUruchomiony = false;
        private int RokProdukcji { get; }

        public Samochód(string m, string k, int p, bool cU, int RP)
        {
            this.model = m;
            this.kolor = k;
            this.przebieg = p;
            this.czyUruchomiony = cU;
            this.RokProdukcji = RP;
        }

        public void UruchomSamochod()
        {
            czyUruchomiony = true;
            Console.WriteLine("Samochód uruchomiono:" + DateTime.Now);
        }

        public void ZatrzymajSamochód()
        {
            if (czyUruchomiony == false)
            {
                Console.WriteLine("Nie można zatrzymać nie uruchomionego samochodu");
            }
            else
            {
                czyUruchomiony = false;
                Console.WriteLine("Ile przejechałeś km?");
                int n = 0;
                int.TryParse(Console.ReadLine(), out n);
                przebieg += n;
                Console.WriteLine("Przebieg aktualnie wynosi:" + przebieg);
                Console.WriteLine("Samochód zatrzymano:" + DateTime.Now);
            }
        }

    }
}
