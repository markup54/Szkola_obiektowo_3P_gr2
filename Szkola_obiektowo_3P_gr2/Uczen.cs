using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola_obiektowo_3P_gr2
{
    public class Uczen:Osoba
    {
        private int nuUcznia;
        private static int liczbaUczniow;

        public Uczen(int nuUcznia)
        {
            this.nuUcznia = nuUcznia;
            liczbaUczniow++;
        }
        public Uczen()
        {
           
            liczbaUczniow++;
            nuUcznia = liczbaUczniow;
        }
        public Uczen(string imie, int wiek) 
            : base(imie, wiek)
        {
            liczbaUczniow++;
            nuUcznia = liczbaUczniow;
        }
    }
}
