using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola_obiektowo_3P_gr2
{
    public class Osoba
    {
        public string imie;
        public int wiek;
        //imie i wiek pola klasy
        //konstruktor
        //metoda wywoływana w momencie tworzenia obiektu
        //przypisuje wartości początkowe do pól klasy
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
