using System;

namespace PrzychodniaWeterynaryjna
{
    public class Uzytkownik
    {
        public int IdUzytkownika { get; set; }
        public string Imie { get; set; } // DODANA WŁAŚCIWOŚĆ
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Rola { get; set; }

        // Konstruktor przyjmujący 6 argumentów
        public Uzytkownik(int idUzytkownika, string imie, string nazwisko, string login, string haslo, string rola)
        {
            IdUzytkownika = idUzytkownika;
            Imie = imie;
            Nazwisko = nazwisko;
            Login = login;
            Haslo = haslo;
            Rola = rola;
        }

        // Możesz dodać inne konstruktory (np. bezparametrowy) jeśli potrzebujesz
        public Uzytkownik()
        {
            // Domyślna inicjalizacja
        }
    }
}