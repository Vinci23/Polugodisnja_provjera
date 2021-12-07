using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Definirajte klasu Stablo sa sljedećim članicama:
a. varijabla tipa bool otpadajuListovi
b. varijabla tipa string vrstaStabla
c. svojstvo OtpadajuListovi (get() i set())
d. konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta
varijabli otpadajuListovi
e. override metode ToString()
Definirajte objekt stablo1 tipa Stablo pomoću konstruktora te proslijedite vrijednost
false. Definirajte objekt stablo2 tipa Stablo pomoću konstruktora te proslijedite
vrijednost true.
Ispišite podatke o objektima koristeći ToString() metodu, na način da ukoliko je
vrijednost varijable otpadajuListovi true, vrijednost varijable vrstaStabla je
bijelogorično, a ukoliko je vrijednost varijable otpadajuListovi false, vrijednost
varijable vrstaStabla je crnogorično.
 *
 */
namespace Polugodisnji_Drugi_zad
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);


            Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());
            Console.ReadKey();
        }


    }
    class Stablo
    {
        bool otpadajulistovi;
        String vrstaStabla;

        public override string ToString()
        {
           

            string ispis = "Vrsta " + this.getVrstaStabla() + "Listovi" +
                 this.getOtpadajuListovi();
                  return ispis;
        }

        
        public Stablo(bool otpadajulistovi)
        {
            this.otpadajulistovi = otpadajulistovi;

            if (otpadajulistovi = true)
            {
                this.vrstaStabla = "Crnogorično";
                    }
            else if (otpadajulistovi = false)
            {
                this.vrstaStabla = "bijelogorično";
            }


        }

        public Stablo()
        {
        }

        public void  setOtpadajuListovi(bool otpadajuListovi)
        {
            this.otpadajulistovi = otpadajulistovi;  
        }

        public void setVrstaStabla()
        {
            this.vrstaStabla = vrstaStabla;
        }

        public bool getOtpadajuListovi()
        {
            return this.otpadajulistovi;
        }

        public String getVrstaStabla()
        {
            return this.vrstaStabla;
        }
    }
}
