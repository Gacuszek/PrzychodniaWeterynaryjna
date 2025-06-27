namespace przychodnia_weteranyjna_ulti
{
    // Klasa Osoba implementuje teraz interfejs IDaneKontaktowe.
    public abstract class Osoba : IDaneKontaktowe
    {
        public int Id { get; set; }
        public string Imie { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public string NumerTelefonu { get; set; } = string.Empty;

        public virtual string WyswietlSzczegoly()
        {
            return $"{Imie} {Nazwisko}, tel: {NumerTelefonu}";
        }
    }
}