using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola_obiektowo_3P_gr2
{
    public class Osoba
    {
        private string imie;
        private int wiek;
        //imie i wiek pola klasy
        //konstruktor
        //metoda wywoływana w momencie tworzenia obiektu
        //przypisuje wartości początkowe do pól klasy

        /*
         * mdyfikatory dostepu
         * private - dostępne tylko w tej klasie, niedostępne w programie głównym
         * public - dostępne wszędzie też w programie głównym
         * protected = dostępne tylko w tek klasie i klasach z niej dziedziczących
         * 
         * jeżeli stosujemy private i protected 
         * to hermetyzacja (inaczej enkapsulacja)
         */
        public Osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public Osoba()
        {
        }

        public override string? ToString()
        {
            return "imię: "+imie+" wiek: "+wiek;
        }

        //przeciążanie konstruktorów - metody o tej samej nazwie
        //różnej liczbie lub typie argumentów



    }
}
