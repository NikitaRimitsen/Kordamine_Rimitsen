using System;
using System.Collections.Generic;
using System.Text;

namespace Kordamine_Rimitsen
{
    class Ulesanne1
    {

        static void Main(string[] argumendid)
        {
            /*Ulessane 1*/
            static bool Vozubvneub(int[] mass, bool ask)
            {
                for (int i = 0; i < mass.Length - 1; i++)
                    if ((ask && (mass[i] > mass[i + 1])) || (!ask && (mass[i] < mass[i + 1]))) return false;
                return true;
            }

            static void Proverka(int[] massiv)
            {
                if (Vozubvneub(massiv, true))
                {
                    Console.WriteLine("Tellitud kasvavas järjekorras");
                }
                else if (Vozubvneub(massiv, false))
                {
                    Console.WriteLine("Kahanevas järjekorras");
                }
                else
                {
                    Console.WriteLine("Pole tellitud");
                }
            }
            var massiv = new[] { 5, 4, 3, 2, 1 };

            Proverka(massiv);

            Console.ReadLine();

        }
    }
}
