﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] tomb = new int[10] {12, 7, 2, 4, 45, 99, 1, 8, 95, 50};

        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ",tomb[i]);
            }
            Console.WriteLine();
            Console.WriteLine("******************************************");
        }

        static void Osszegzes()
        {
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine("Tömb elemeinek összege: {0}",osszeg);
            Console.WriteLine("------------------------------------------");
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Console.ReadKey();
        }
    }
}
