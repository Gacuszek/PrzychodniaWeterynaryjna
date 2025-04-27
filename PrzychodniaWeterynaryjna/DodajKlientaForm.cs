using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrzychodniaWeterynaryjna
{
    public partial class DodajKlientaForm : Form
    {
        private DataAccess dataAccess = new DataAccess();

        public DodajKlientaForm()
        {
            InitializeComponent();
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            // Pobierz dane z pól tekstowych
            string imie = imieTextBox.Text;
            string nazwisko = nazwiskoTextBox.Text;
            string adres = adresTextBox.Text;
            string telefon = telefonTextBox.Text;

            // Sprawdź, czy wszystkie wymagane pola są wypełnione
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) || string.IsNullOrWhiteSpace(adres) || string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Stwórz nowy obiekt Klient
            Klient nowyKlient = new Klient(0, imie, nazwisko, adres, telefon); // ID zostanie wygenerowane przez bazę danych

            // Wywołaj metodę z DataAccess, aby dodać klienta do bazy danych
            if (dataAccess.DodajKlienta(nowyKlient))
            {
                MessageBox.Show("Klient został pomyślnie dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Ustaw wynik dialogowy na OK
                this.Close(); // Zamknij formularz
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Ustaw wynik dialogowy na Cancel
            this.Close(); // Zamknij formularz
        }

        private void DodajKlientaForm_Load(object sender, EventArgs e)
        {
            // Możesz tutaj dodać logikę, która ma się wykonać przy załadowaniu formularza
            // Na razie nie mamy tu nic specjalnego.
        }
    }
}