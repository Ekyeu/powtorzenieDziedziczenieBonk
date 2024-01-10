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
        double calykoszyk = 0.0;


        public Klient(string imie, string nazwisko) :base (imie, nazwisko) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void dodawanieKsiazki(IProdukt produkt, Ksiazka produkt1)
        {
            if(produkt == null)
            {
                Console.WriteLine("Nie mozna dodac, gdyz nie ma dostepnych produktow");
            }
            else
            {
                koszyk.Add(produkt);
                produkt1.ilosc--;
                calykoszyk += produkt1.cena;

            }
            Console.WriteLine($"DOstepna ilosc {produkt1.ilosc}");
        }

        public void dodawanieELektroniki(IProdukt produkt, Elektronika produkt1)
        {
            if (produkt == null)
            {
                Console.WriteLine("Nie mozna dodac, gdyz nie ma dostepnych produktow");
            }
            else
            {
                koszyk.Add(produkt);
                produkt1.ilosc--;
                calykoszyk += produkt1.cena;
            }
            Console.WriteLine($"DOstepna ilosc {produkt1.ilosc}");
        }

        public void dodawanieOdziez(IProdukt produkt, Odziez produkt1)
        {
            if (produkt == null)
            {
                Console.WriteLine("Nie mozna dodac, gdyz nie ma dostepnych produktow");
            }
            else
            {
                koszyk.Add(produkt);
                produkt1.ilosc--;
                calykoszyk += produkt1.cena;
            }
            Console.WriteLine($"DOstepna ilosc {produkt1.ilosc}");
        }


        public void cenaKsiazka(Ksiazka produkt1)
        {
            Console.WriteLine($"Cena Ksiazka ;P  {produkt1.cena}");
        }

        public void cenaElektronika(Elektronika produkt1)
        {
            Console.WriteLine($"Cena Elektronika ;P  {produkt1.cena}");
        }

        public void cenaOdziez(Odziez produkt1)
        {
            Console.WriteLine($"Cena Odziezs ;P  {produkt1.cena}");
        }

        public void cenaKoszyka()
        {
            Console.WriteLine($"Cena koszyka ;P  {calykoszyk}");
        }
    }
}
