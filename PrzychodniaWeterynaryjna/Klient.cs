using System;

namespace PrzychodniaWeterynaryjna
{
    public class Klient
    {
        public int IdKlienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        // Konstruktor klasy Klient
        public Klient(int idKlienta, string imie, string nazwisko, string adres, string telefon)
        {
            IdKlienta = idKlienta;
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Telefon = telefon;
        }

        // Możesz dodać inne konstruktory lub metody do klasy Klient w przyszłości
    }
}