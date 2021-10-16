using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kordamine_Rimitsen
{
    class Ulesanne2
    {



        static void Main(string[] args)
        {
            /*Random rnd = new Random();
            int N = rnd.Next(1,50);
            int M = rnd.Next(-10, 10);
            int[] cisla = new int[N] { M };

            Console.WriteLine(cisla);*/





            /*Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            Console.WriteLine(r);
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(0,2);
                Console.WriteLine(a);
                if (a[i] > -10 && a[i] < 10) count++;
            }
            Console.WriteLine("Count {0}", count);*/

            Random rnd = new Random();

            Console.Write("N: ");
            var N = int.Parse(Console.ReadLine());
            var cislo = new int[N];
            var rasct = 0;
            for (var i = 0; i < N; i++)
            {
                cislo[i] = rnd.Next(1, 50);
                if (cislo[i] > -10 && cislo[i] < 10) rasct++;
            }
            Console.WriteLine($"Count {rasct}");



            Console.ReadLine();
        }

    }
}
