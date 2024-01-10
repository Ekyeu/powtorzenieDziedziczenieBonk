using powtorzenieBonk;

Ksiazka ksiazka = new Ksiazka(10.5,"To jest ksiazka",20);
Elektronika elektronika = new Elektronika(100, "To jest Elektronika", 11);
Odziez odziez = new Odziez(35.5, "To jest Odziez", 24);



Klient klient = new Klient("Andrzej", "Komar");
klient.dodawanieKsiazki(ksiazka, ksiazka);

klient.dodawanieELektroniki(elektronika, elektronika);

klient.dodawanieOdziez(odziez, odziez);
klient.dodawanieOdziez(odziez, odziez);


klient.cenaKsiazka(ksiazka);

klient.cenaElektronika(elektronika);

klient.cenaOdziez(odziez);


klient.cenaKoszyka();