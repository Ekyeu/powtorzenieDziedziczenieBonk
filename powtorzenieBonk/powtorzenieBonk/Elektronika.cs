using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzenieBonk
{
    public class Elektronika : IProdukt
    {
        public double cena;
        public string info;
        public int ilosc;

        public Elektronika(double cena, string info, int ilosc)
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
