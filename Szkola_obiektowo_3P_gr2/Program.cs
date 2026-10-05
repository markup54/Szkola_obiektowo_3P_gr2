// See https://aka.ms/new-console-template for more information
using Szkola_obiektowo_3P_gr2;

Console.WriteLine("Hello, World!");

/*Osoba osoba = new Osoba(); // tworzymy nowy obiekt - wywołujemy konstruktor
jeżeli klasa Osoba abstrakcyjna nie mogę utworzyć obiektu tej klasy
//osoba.imie = "Genowefa"; // publiczne więc można zmieniac

//Console.WriteLine("imię osoba");
//Console.WriteLine(osoba.imie);
Osoba osoba2 = new Osoba("Brunchilda",80);
//Console.WriteLine("imię osoba2");
//Console.WriteLine(osoba2.imie);
Console.WriteLine(osoba2); // wywołuje się metoda ToString()
*/
Console.WriteLine("liczba uczniów " + Uczen.liczbaUczniow);
//odwołanie do pola statycznego liczba uczniów
//nazwa_klasy.nazwa pola
Uczen uczen1 = new Uczen();
Console.WriteLine(uczen1);//wywołuje się ToString z klasy Uczen
Console.WriteLine("liczba uczniów " + Uczen.liczbaUczniow);
Uczen uczen2 = new Uczen(7);
Console.WriteLine(uczen2);
Console.WriteLine("liczba uczniów " + Uczen.liczbaUczniow);
Uczen uczen3 = new Uczen("Jaś",13);
Console.WriteLine(uczen3);
Console.WriteLine("liczba uczniów " + Uczen.liczbaUczniow);
Nauczyciel nauczyciel = new Nauczyciel("Anna",60,"wf");
Console.WriteLine(nauczyciel);
