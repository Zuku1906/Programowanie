using System;
using System.Collections.Generic;
using System.Text;

namespace Zaj11_zad2
{
    class Fibonacci
    {
        public static int ObliczNtyElement(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return ObliczNtyElement(n - 1) + ObliczNtyElement(n - 2);
            }
        }

        public static int ObliczSumeNelementów(byte n)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += ObliczNtyElement(i);
            }
            return suma;
        }

        public static string PodajInformacje()
        {
            return
                "Ciąg Fibonacciego - ciąg liczb naturalnych określony rekurencyjnie w sposób następujący: Zerowy wyraz jest równy 0, pierwszy jest równy 1, każdy następny jest sumą dwóch poprzednich.";
        }
    }
}
