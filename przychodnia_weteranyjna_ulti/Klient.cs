using System.Collections.Generic;

namespace przychodnia_weteranyjna_ulti
{
    public class Klient : Osoba
    {
        public string Email { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public List<Zwierze> Zwierzeta { get; set; } = new List<Zwierze>();

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }


        public override string WyswietlSzczegoly()
        {
            return $"Klient: {Imie} {Nazwisko}, Email: {Email}";
        }
    }
}