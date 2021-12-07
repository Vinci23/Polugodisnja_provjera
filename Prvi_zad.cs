using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///Napišite program koji će zatražiti od korisnika da unese tri
//dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja (npr. 12,17,15 ->
//17).
/// </summary>
namespace Polugodisnji_Prvi_zad
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int prviBroj = 0;
            int drugiBroj = 0;
            int treciBroj = 0;
            Console.WriteLine("Unesi tri dvoznamenkasta broja:" + "\n");


            prviBroj = Convert.ToInt32(Console.ReadLine());
            drugiBroj = Convert.ToInt32(Console.ReadLine());
            treciBroj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("   ");

            if (prviBroj > drugiBroj && prviBroj > treciBroj)
            {
                Console.WriteLine(prviBroj);
            }


            if (drugiBroj > treciBroj && drugiBroj > prviBroj)
            {
                Console.WriteLine(drugiBroj);
            }

                if (treciBroj > drugiBroj && treciBroj > prviBroj)
                {
                    Console.WriteLine(treciBroj);
                }




                Console.ReadKey();
            }
        }
    }

