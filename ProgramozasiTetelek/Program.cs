using System;
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

        static void Megszamlalas()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3==0)
                {
                    db++;
                }
            }
            Console.WriteLine("{0} db hárommal osztható szám van a tömbben", db);
            Console.WriteLine("------------------------------------------");
        }

        static void Eldontes()
        { 
            bool vane = false;
            int j = 0;
            while (vane == false && j < tomb.Length)
            {
                if (tomb[j]==69)
                {
                    vane = true;
                }
                j++;
            }

            if (vane == true)
            {
                Console.WriteLine("Van a tömbben 69");
                Console.WriteLine("------------------------------------------");

            }
            else
            {
                Console.WriteLine("Nincs a tömbben 69");
                Console.WriteLine("------------------------------------------");

            }
        }

        static void Kivalasztas()
        {
            //int index = 0;
            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (tomb[i]==50)
            //    {
            //        index = i;
            //    }
            //}
            //Console.WriteLine("Az 50 a {0}. indexű elem, a {1}. helyen áll a tömbben",index, index+1);

            int j = 0;
            while (j<tomb.Length && tomb[j]!=50)
            {
                j++;
            }
            Console.WriteLine("Az 50 a {0}. indexű elem, a {1}. helyen áll a tömbben", j, j+1);
            Console.WriteLine("------------------------------------------");

        }

        static void Kereses()
        {
            int j = 0;
            while (j < tomb.Length && tomb[j] != 50)
            {
                j++;
            }
            
            Console.WriteLine("Az 50 a {0}. indexű elem, a {1}. helyen áll a tömbben", j, j + 1);
            Console.WriteLine("------------------------------------------");
        }

        static void max()
        {
            int max = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (max>tomb[i])
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine("Tömb legnagyobb eleme {0}", max);
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamlalas();
            Eldontes();
            Kivalasztas();
            Kereses();
            max();
            Console.ReadKey();
        }
    }
}
