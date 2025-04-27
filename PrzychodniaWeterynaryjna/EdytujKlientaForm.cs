using System;
using System.Windows.Forms;

namespace PrzychodniaWeterynaryjna
{
    public partial class EdytujKlientaForm : Form
    {
        private DataAccess dataAccess = new DataAccess();
        private Klient klientDoEdycji;

        public EdytujKlientaForm(Klient klient)
        {
            InitializeComponent();
            MessageBox.Show($"Konstruktor EdytujKlientaForm: {klient.Imie} {klient.Nazwisko}"); // DODANA LINIA
            klientDoEdycji = klient;
            WyswietlDaneKlienta();
        }

        private void WyswietlDaneKlienta()
        {
            imieTextBoxEdycja.Text = klientDoEdycji.Imie;
            nazwiskoTextBoxEdycja.Text = klientDoEdycji.Nazwisko;
            adresTextBoxEdycja.Text = klientDoEdycji.Adres;
            telefonTextBoxEdycja.Text = klientDoEdycji.Telefon;
        }

        private void zapiszButtonEdycja_Click(object sender, EventArgs e)
        {
            // Pobierz zaktualizowane dane z pól tekstowych
            string imie = imieTextBoxEdycja.Text;
            string nazwisko = nazwiskoTextBoxEdycja.Text;
            string adres = adresTextBoxEdycja.Text;
            string telefon = telefonTextBoxEdycja.Text;

            // Sprawdź, czy wszystkie pola są wypełnione (możesz dodać bardziej zaawansowaną walidację)
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) || string.IsNullOrWhiteSpace(adres) || string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Utwórz nowy obiekt Klient z zaktualizowanymi danymi i ID edytowanego klienta
            Klient zaktualizowanyKlient = new Klient(klientDoEdycji.IdKlienta, imie, nazwisko, adres, telefon);

            // Wywołaj metodę z DataAccess do zaktualizowania klienta w bazie danych
            if (dataAccess.EdytujKlienta(zaktualizowanyKlient))
            {
                MessageBox.Show("Dane klienta zostały pomyślnie zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Ustaw wynik dialogowy na OK
                this.Close(); // Zamknij formularz
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizacji danych klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anulujButtonEdycja_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Ustaw wynik dialogowy na Cancel
            this.Close(); // Zamknij formularz
        }
    }
}