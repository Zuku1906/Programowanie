using System;
using System.Collections.Generic;
using System.Text;

namespace GlencWersjaC
{
    class Dokument
    {
        int liczbaStron;
        DateTime dataUtworzenia;
        public Dokument(int liczbaStron, DateTime dataUtworzenia)
        {
            this.liczbaStron = liczbaStron;
            this.dataUtworzenia = dataUtworzenia;
        }
        public void WyswietlDaneDokumentu()
        {
            Console.WriteLine($"Liczba stron: {liczbaStron} Data utworzenia: {dataUtworzenia.ToShortDateString()}");
        }

        public static Dokument operator +(Dokument x1, Dokument x2)
        {
            if (x2.dataUtworzenia < x1.dataUtworzenia)
            {
                return new Dokument(x1.liczbaStron + x2.liczbaStron, x2.dataUtworzenia);
            }
            else
            {
                return new Dokument(x1.liczbaStron + x2.liczbaStron, x1.dataUtworzenia);
            }
        }
    }
}
