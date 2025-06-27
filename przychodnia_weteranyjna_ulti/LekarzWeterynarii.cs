namespace przychodnia_weteranyjna_ulti
{
    public class LekarzWeterynarii : Osoba
    {
        public string NumerPWZ { get; set; } = string.Empty;
        public string Specjalizacja { get; set; } = string.Empty;


        public string Info => $"{Specjalizacja} - {Imie} {Nazwisko}";


        public override string WyswietlSzczegoly()
        {
            return $"Lekarz: {Imie} {Nazwisko} (Specjalizacja: {Specjalizacja})";
        }
    }
}