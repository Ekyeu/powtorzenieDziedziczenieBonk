using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzenieBonk
{
    internal class Klient : Osoba
    {
        List<IProdukt> koszyk = new List<IProdukt>();
        string imie = "Janek";
        string nazwisko = "Towarek";

        public Klient(List<IProdukt> koszyk, string imie, string nazwisko) :base (imie, nazwisko) 
        {
            this.koszyk = koszyk;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void dodawanie(IProdukt produkt)
        {
            if(produkt == null)
            {
                Console.WriteLine("Nie mozna dodac, gdyz nie ma produktow dostepnych");
            }
            else
            {
                koszyk.Add(produkt);
            }
        }

    }
}
