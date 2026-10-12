using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cwiczenia_c__2
{
    internal class film
    {
        //*****************************************************
        // nazwa klasy: film
        // pola:
        //   tytul - przechowuje tytuł filmu
        //   liczbaWypozyczen - przechowuje liczbę wypożyczeń danego filmu
        // metody:
        //   ustawTytul, nic nie zwraca - ustawia pole tytul
        //   wypiszTytul, string tytul - zwraca wartość pola tytul
        //   wypiszLiczbeWypozyczen, int liczbyWypozyczen - zwraca wartość pola LiczbaWypozyczen
        //   wypozycz, nic nie zwraca - zwiększa wartośc pola LiczbaWypozyczen o 1
        // informacje: Klasa opisuje film posiadający tytuł, który może być wypożyczony.
        // autor: 0000
        //*****************************************************

        protected string tytul;
        protected int liczbaWypozyczen;
        public film()
        {
            tytul = string.Empty;
            liczbaWypozyczen = 0;
        }
        public void ustawTytul(string _tytul)
        {
            tytul = _tytul;
        }
        public string wypiszTytul()
        {
            return tytul;
        }
        public int wypiszLiczbeWypozyczen()
        {
            return liczbaWypozyczen;
        }
        public void wypozycz()
        {
            liczbaWypozyczen++;
        }
    }
}
