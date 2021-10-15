using System;
using System.Collections.Generic;
using System.Text;

namespace Kordamine_Rimitsen
{
    class Alamprogramme
    {
        public static bool Vozubvneub(int[] mass, bool ask)
        {
            for (int i = 0; i < mass.Length - 1; i++)
                if ((ask && (mass[i] > mass[i + 1])) || (!ask && (mass[i] < mass[i + 1]))) return false;
            return true;
        }

        public static void Proverka(int[] a)
        {
            if (Vozubvneub(a, true))
            {
                Console.WriteLine("Upodaracen");
            }
            else if (Vozubvneub(a, false))
            {
                Console.WriteLine("Upodaracen po ubevaniu");
            }
            else
            {
                Console.WriteLine("Ne upodaracen");
            }
        }

        public static void Proverku(int a, int n, int r)
        {
            for (var i = 0; i < n; i++)
            {

            }
        }

    }
}
