﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powtorzenieBonk
{
    public interface IProdukt
    {
        public string wyswietlInfo();

        public double aktualnaCena();

        public int dostepnaIlosc();

    }
}
