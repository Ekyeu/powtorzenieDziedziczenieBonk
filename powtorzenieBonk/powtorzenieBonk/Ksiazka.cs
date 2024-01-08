using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzenieBonk
{
    public class Ksiazka : IProdukt
    {
        public double cena = 3;
        public string info = "ss";
        public int ilosc = 3;

        public Ksiazka(double cena, string info, int ilosc)
        {
            this.cena = cena;
            this.info = info;
            this.ilosc = ilosc;
        }

        public double aktualnaCena()
        {
            return cena;
        }

        public int dostepnaIlosc()
        {
            return ilosc;
        }

        public string wyswietlInfo()
        {
            return info;
        }
    }
}
