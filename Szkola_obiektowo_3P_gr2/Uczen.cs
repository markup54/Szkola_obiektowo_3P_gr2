using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkola_obiektowo_3P_gr2
{
    public class Uczen:Osoba
    {
        //klasą potomną jest Uczen, klasą bazową Osoba
        //dziedziczenie

        private int nuUcznia;
        public static int liczbaUczniow = 0;
        //static to pole dla klasy nie dla obiektu
        //każdy obiekt będzie widział tą samą wartość

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
            //base - odwołanie do konstruktora klasy bazowej
            liczbaUczniow++;
            nuUcznia = liczbaUczniow;
        }

        public override string? ToString()
        {
            return base.ToString() + "nr ucznia: "+nuUcznia;
        }
    }
}
