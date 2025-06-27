using System;
using System.Collections.Generic;

namespace przychodnia_weteranyjna_ulti
{
    public class Wizyta
    {
        public int Id { get; set; }
        public DateTime DataWizyty { get; set; }
        public LekarzWeterynarii Lekarz { get; set; } = new LekarzWeterynarii();
        public Zwierze Pacjent { get; set; } = new Zwierze();
        public string Opis { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Badanie { get; set; } = string.Empty;
        public string Diagnoza { get; set; } = string.Empty;
        public string Zalecenia { get; set; } = string.Empty;
        public string Leki { get; set; } = string.Empty;
        public DateTime? DataKontroli { get; set; }
        public float Waga { get; set; }
        public float Temperatura { get; set; }
        public decimal KosztWizyty { get; set; }

        public string PacjentInfo => $"{Pacjent.Imie} ({Pacjent.Wlasciciel.Nazwisko})";
        public string LekarzInfo => $"{Lekarz.Imie} {Lekarz.Nazwisko}";
    }
}