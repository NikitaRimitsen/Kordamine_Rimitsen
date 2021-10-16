using System;
using System.Collections.Generic;
using System.Text;

namespace Kordamine_Rimitsen
{
    class Ulesanne3
    {

        static void Main(string[] argumendid)
        {
            string[] Mperenimi = { "Kuznec Ivan Stepanovic", "Sapoznikov Petja ivanovic", "Pupkin Vasja Ivanovic", "Utkin Daniil Romanovic" };
            string[] Madress = { "Puskinskaja-dom 16", "Pobednaja-dom 24", "Moika-dom 5", "Kosmonavtov-dom 16" };
            int[] Mgod = { 1998, 2004, 1956, 1984 };
            int[] Mmesac = { 07, 10, 08, 02 };
            int[] Mden = { 15, 04, 27, 01 };


            int a = Mgod[0];
            int b = Mgod[1];
            int c = Mgod[2];
            //Console.WriteLine(a + "," + b + "," + c);

            //ArrayWriteLine(izbiratel1);
            int scetcik = 0;

            for (int i = 0; i < Mperenimi.Length; i++)
            {

                if (Mgod[scetcik] < 2004)
                {

                    Array.Sort(Madress, Mperenimi);
                    Console.WriteLine(Madress[scetcik] + ", " + Mperenimi[scetcik]);
                }
                else
                {
                    Console.WriteLine(Mperenimi[scetcik] + " - ei saa osaleda, sest tal on vähem kui 18 aastat.");
                }

                scetcik++;

            }

            Console.ReadLine();

        }
    }
}
