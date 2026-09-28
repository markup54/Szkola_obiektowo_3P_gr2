// See https://aka.ms/new-console-template for more information
using Szkola_obiektowo_3P_gr2;

Console.WriteLine("Hello, World!");

Osoba osoba = new Osoba(); // tworzymy nowy obiekt - wywołujemy konstruktor
osoba.imie = "Genowefa"; // publiczne więc można zmieniac

Console.WriteLine("imię osoba");
Console.WriteLine(osoba.imie);
Osoba osoba2 = new Osoba("Brunchilda",80);
Console.WriteLine("imię osoba2");
Console.WriteLine(osoba2.imie);
Console.WriteLine(osoba2); // wywołu się metoda ToString()
