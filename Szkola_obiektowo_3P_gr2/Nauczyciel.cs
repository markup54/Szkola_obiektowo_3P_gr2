using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola_obiektowo_3P_gr2
{
    public class Nauczyciel:Osoba
    {
        private string przedmiot;

        public Nauczyciel()
        {
        }

        public Nauczyciel(string imie, int wiek ,
            string przedmiot) : base(imie, wiek)
        {
            this.przedmiot = przedmiot;
            //this.przedmiot - pole klasy
            //przedmiot zmienna lokalna w konstruktorze
        }
    }
}
