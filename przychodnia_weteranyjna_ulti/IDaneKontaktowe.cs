namespace przychodnia_weteranyjna_ulti
{
    /// <summary>
    /// Interfejs definiujący kontrakt dla bytów posiadających podstawowe dane kontaktowe.
    /// </summary>
    public interface IDaneKontaktowe
    {
        string Imie { get; set; }
        string Nazwisko { get; set; }
        string NumerTelefonu { get; set; }
    }
}