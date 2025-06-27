using System;
using System.Collections.Generic;

namespace przychodnia_weteranyjna_ulti
{
    public class Zwierze
    {
        public int Id { get; set; }
        public string Imie { get; set; } = string.Empty;
        public string Gatunek { get; set; } = string.Empty;
        public string Rasa { get; set; } = string.Empty;
        public DateTime DataUrodzenia { get; set; }
        public Klient Wlasciciel { get; set; } = new Klient();

        public override string ToString()
        {
            return $"{Imie} ({Gatunek})";
        }

        public string InfoDlaWizyty => $"{Imie} (wł. {Wlasciciel.Nazwisko})";
    }
}